using ordemServico.DAL;
using ordemServico.Database;
using ordemServico.Model;

namespace ordemServico;

public partial class Frm_ListaVeiculo : Form
{
	private GsoContext _context;
	private DAL<VeiculoModel> _veiculoDal;

	public int VeiculoId { get; private set; }
	public string? Placa { get; private set; }
	public string? Modelo { get; private set; }
	public Frm_ListaVeiculo()
	{
		_context = new GsoContext();
		_veiculoDal = new DAL<VeiculoModel>(_context);

		InitializeComponent();
	}

	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);

		var listaVeiculos = _veiculoDal.Listar();
		if (listaVeiculos == null) return;
		dataGridView1.DataSource = listaVeiculos;
		ConfigurarColunaDataGrid();
	}

	private void ConfigurarColunaDataGrid()
	{
		dataGridView1.Columns["IdVeiculo"].HeaderText = "Registro";
		dataGridView1.Columns["IdVeiculo"].Width = 120;
		dataGridView1.Columns["IdVeiculo"].ReadOnly = true;

		dataGridView1.Columns["Prefixo"].HeaderText = "Prefixo";
		dataGridView1.Columns["Prefixo"].Width = 120;
		dataGridView1.Columns["Prefixo"].ReadOnly = true;

		dataGridView1.Columns["Placa"].HeaderText = "Placa";
		dataGridView1.Columns["Placa"].Width = 120;
		dataGridView1.Columns["Placa"].ReadOnly = true;

		dataGridView1.Columns["Marca"].HeaderText = "Marca";
		dataGridView1.Columns["Marca"].Width = 150;
		dataGridView1.Columns["Marca"].ReadOnly = true;

		dataGridView1.Columns["Modelo"].HeaderText = "Modelo";
		dataGridView1.Columns["Modelo"].Width = 250;
		dataGridView1.Columns["Modelo"].ReadOnly = true;
	}

	private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		VeiculoId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["IdVeiculo"].Value);
		Placa = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Placa"].Value.ToString();
		Modelo = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Modelo"].Value.ToString();
		DialogResult = DialogResult.OK;
	}

	private void Txt_Pesquisa_TextChanged(object sender, EventArgs e)
	{
		var listaVeiculos = _veiculoDal.Pesquisa(Txt_Pesquisa.Text);
		dataGridView1 .DataSource = listaVeiculos;
		ConfigurarColunaDataGrid();
	}
}
