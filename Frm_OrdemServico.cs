using ordemServico.Database;
using ordemServico.Enums;
using ordemServico.Model;
using ordemServico.Service;

namespace ordemServico;

public partial class Frm_OrdemServico : Form
{
	private GsoContext _context;
	private OrdemServicoService _ordemServicoService;
	private readonly UsuarioModel _usuario;

	public Frm_OrdemServico(UsuarioModel _usuario)
	{
		_context = new GsoContext();
		this._usuario = _usuario;
		_ordemServicoService = new OrdemServicoService(_context);
		InitializeComponent();
	}

	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);

		var listaOrdemServicos = _ordemServicoService.Listar();
		if (listaOrdemServicos == null) return;
		dataGridView1.DataSource = listaOrdemServicos;
		ConfigurarColunaDataGrid();
	}

	private void ConfigurarColunaDataGrid()
	{
		dataGridView1.Columns["IdOrdemServico"].HeaderText = "Registro";
		dataGridView1.Columns["IdOrdemServico"].Width = 120;
		dataGridView1.Columns["IdOrdemServico"].ReadOnly = true;

		dataGridView1.Columns["Status"].HeaderText = "Status";
		dataGridView1.Columns["Status"].Width = 120;
		dataGridView1.Columns["Status"].ReadOnly = true;

		dataGridView1.Columns["Status"].HeaderText = "Status";
		dataGridView1.Columns["Status"].Width = 120;
		dataGridView1.Columns["Status"].ReadOnly = true;

		dataGridView1.Columns["DataAbertura"].HeaderText = "Data Abertura";
		dataGridView1.Columns["DataAbertura"].Width = 150;
		dataGridView1.Columns["DataAbertura"].ReadOnly = true;

		dataGridView1.Columns["DataFechamento"].HeaderText = "Data Fechamento";
		dataGridView1.Columns["DataFechamento"].Width = 150;
		dataGridView1.Columns["DataFechamento"].ReadOnly = true;

		dataGridView1.Columns["Chamada"].HeaderText = "Chamada";
		dataGridView1.Columns["Chamada"].Width = 120;
		dataGridView1.Columns["Chamada"].ReadOnly = true;

		dataGridView1.Columns["PlacaVeiculo"].HeaderText = "Placa";
		dataGridView1.Columns["PlacaVeiculo"].Width = 120;
		dataGridView1.Columns["PlacaVeiculo"].ReadOnly = true;

		dataGridView1.Columns["ModeloVeiculo"].HeaderText = "Modelo";
		dataGridView1.Columns["ModeloVeiculo"].Width = 220;
		dataGridView1.Columns["ModeloVeiculo"].ReadOnly = true;

		dataGridView1.Columns["Nome"].HeaderText = "Nome";
		dataGridView1.Columns["Nome"].Width = 250;
		dataGridView1.Columns["Nome"].ReadOnly = true;

		dataGridView1.Columns["UsuarioId"].Visible = false;
	}

	private void NovaOrdemServicoToolStripButton_Click(object sender, EventArgs e)
	{
		var frm = new Frm_OrdemServicoRegistro(0, _usuario, Controle.Toadd);
		frm.ShowDialog();
		OnLoad(e);
	}

	private void abrirToolStripButton_Click(object sender, EventArgs e)
	{
		if (dataGridView1.Rows.Count > 0)
		{
			int id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["IdOrdemServico"].Value);
			int usuarioId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["UsuarioId"].Value);

			if (usuarioId != _usuario.IdUsuario && _usuario.Perfil != Perfil.Administrador)
			{
				MessageBox.Show("Usuário não administrador pada poder editar!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			var frm = new Frm_OrdemServicoRegistro(id, _usuario, Controle.ToUpdate);
			frm.ShowDialog();
			OnLoad(e);
		}
	}

	private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
	{
		if (dataGridView1.Columns[e.ColumnIndex].Name == "Status")
		{
			object cellValue = e.Value;

			if (cellValue is Status)
			{
				Status status = (Status)cellValue;

				switch (status)
				{
					case Status.EmAberto:
						e.Value = "Em Aberto";
						break;

					case Status.EmAnalise:
						e.Value = "Em Análise";
						e.CellStyle.BackColor = Color.Orange;
						break;

					case Status.Aprovado:
						e.Value = "Aprovado";
						e.CellStyle.BackColor = Color.Green;
						break;

					case Status.Recusado:
						e.Value = "Recusado";
						e.CellStyle.BackColor = Color.Tomato;
						break;
				}
			}
		}
	}
}
