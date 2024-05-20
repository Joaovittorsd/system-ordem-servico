using Microsoft.EntityFrameworkCore;
using ordemServico.Model;

namespace ordemServico.Database;

public class GsoContext : DbContext
{
	private string _connectionString = "";

	public GsoContext(DbContextOptions options) : base(options) { }

	public GsoContext() { }

	protected override void OnConfiguring(DbContextOptionsBuilder option)
	{
		if (!option.IsConfigured)
		{
			try
			{
				option
					.UseLazyLoadingProxies()
					.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString))
					.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
			}
			catch (Exception ex)
			{
				DialogResult result = MessageBox.Show("Erro: Por favor, entre em contato com o administrador do sistema. Existem atualizações pendentes ou sem conexão com internet. Deseja tentar conectar-se novamente?", "Pendências de atualizações", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

				if (result == DialogResult.OK)
				{
					OnConfiguring(option);
				}
				else
				{
					Application.Exit();
				}
			}
		}
	}

	public DbSet<ChamadaModel> Chamadas { get; set; }
	public DbSet<OrdemServicoModel> OrdensServicos { get; set; }
	public DbSet<SolicitanteModel> Solicitantes { get; set; }
	public DbSet<UsuarioModel> Usuarios { get; set; }
	public DbSet<VeiculoModel> Veiculos { get; set; }
	public DbSet<ItemOrdemDeServicoModel> itensOrdensServicos { get; set; }

}
