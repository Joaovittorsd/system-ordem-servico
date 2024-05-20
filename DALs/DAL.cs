using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using ordemServico.Database;
using System.Linq.Expressions;

namespace ordemServico.DAL;

public class DAL<T> where T : class
{
	private readonly GsoContext _context;

	public DAL(GsoContext context)
	{
		_context = context;
	}

	public IEnumerable<T> Listar()
	{
		return _context.Set<T>()
					  .ToList();
	}

	public T? Adicionar(T? objeto)
	{
		try
		{
			_context.Set<T>().Add(objeto);
			_context.SaveChanges();
			return objeto;
		}
		catch (MySqlException ex)
		{
			MessageBox.Show($"Erro ao adicionar objeto: {ex.Message}.\n\nContate o Administrador do Sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return null;
		}
	}

	public T? Atualizar(T objeto)
	{
		try
		{
			_context.Set<T>().Update(objeto);
			_context.SaveChanges();
			return objeto;
		}
		catch (MySqlException ex)
		{
			MessageBox.Show($"Erro ao Atualizar objeto: {ex.Message}.\n\nContate o Administrador do Sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return null;
		}
	}

	public void Deletar(int id)
	{
		var entity = _context.Set<T>().Find(id);
		if (entity != null)
		{
			_context.Set<T>().Remove(entity);
			_context.SaveChanges();
		}
	}

	public int ObterTotalRegistros()
	{
		return _context.Set<T>().Count();
	}

	public IEnumerable<T> RecuperarPor(Func<T, object> ordenacao = null, params Func<T, bool>[] condicoes)
	{
		IQueryable<T> query = _context.Set<T>();
		foreach (var condicao in condicoes)
			query = query.Where(condicao).AsQueryable();

		if (ordenacao != null)
			query = query.OrderBy(ordenacao).AsQueryable();

		return query.ToList();
	}

	public IEnumerable<T> Pesquisa(string pesquisa)
	{
		var parameter = Expression.Parameter(typeof(T), "x");
		var properties = typeof(T).GetProperties()
								   .Where(p => p.PropertyType == typeof(string));

		Expression body = null;

		foreach (var property in properties)
		{
			var propertyExpression = Expression.Property(parameter, property);
			var containsExpression = Expression.Call(propertyExpression, "Contains", null, Expression.Constant(pesquisa));
			var nullCheckExpression = Expression.NotEqual(propertyExpression, Expression.Constant(null));

			var combinedExpression = Expression.AndAlso(nullCheckExpression, containsExpression);

			if (body == null)
				body = combinedExpression;
			else
				body = Expression.OrElse(body, combinedExpression);
		}

		var lambda = Expression.Lambda<Func<T, bool>>(body, parameter);
		return _context.Set<T>().Where(lambda).ToList();
	}
}
