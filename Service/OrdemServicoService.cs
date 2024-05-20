using MySqlConnector;
using ordemServico.Database;

namespace ordemServico.Service;

internal class OrdemServicoService
{
	private readonly GsoContext _context;

	public OrdemServicoService(GsoContext context)
	{
		_context = context;
	}

	public IEnumerable<object> Listar()
	{
		try
		{
			var query = (from os in _context.OrdensServicos
						 join c in _context.Chamadas on os.ChamadaId equals c.IdChamada into joinedChamadas
						 from chamada in joinedChamadas.DefaultIfEmpty()
						 join v in _context.Veiculos on os.VeiculoId equals v.IdVeiculo into joinedVeiculos
						 from veiculo in joinedVeiculos.DefaultIfEmpty()
						 select new
						 {
							 os.IdOrdemServico,
							 os.Status,
							 os.DataAbertura,
							 os.DataFechamento,
							 Chamada = chamada.Chamada, // Renomeando para evitar ambiguidade
							 PlacaVeiculo = veiculo.Placa, // Renomeando para evitar ambiguidade
							 ModeloVeiculo = veiculo.Modelo, // Renomeando para evitar ambiguidade
							 os.Solicitante.Nome,
							 os.UsuarioId
						 })
						.OrderByDescending(p => p.IdOrdemServico)
						.ToList();

			return query;
		}
		catch (MySqlException ex)
		{
			Console.WriteLine(ex.ToString());
			return null;
		}
	}

}
