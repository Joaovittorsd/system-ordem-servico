using ordemServico.DAL;
using ordemServico.Database;
using ordemServico.Model;

namespace ordemServico;

public partial class Frm_ListaChamada : Form
{
	private GsoContext _context;
	private DAL<ChamadaModel> _chamadaDal;

	public int ChamadaId { get; private set; }
	public string? Chamada { get; private set; }

	public Frm_ListaChamada()
	{
		_context = new GsoContext();
		_chamadaDal = new DAL<ChamadaModel>(_context);
		InitializeComponent();
	}

	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);

		var listaChamada = _chamadaDal.Listar();
		if (listaChamada == null) return;
		dataGridView1.DataSource = listaChamada;
		ConfigurarColunaDataGrid();
	}

	private void ConfigurarColunaDataGrid()
	{
		dataGridView1.Columns["IdChamada"].HeaderText = "Registro";
		dataGridView1.Columns["IdChamada"].Width = 120;
		dataGridView1.Columns["IdChamada"].ReadOnly = true;

		dataGridView1.Columns["Chamada"].HeaderText = "Chamada";
		dataGridView1.Columns["Chamada"].Width = 250;
		dataGridView1.Columns["Chamada"].ReadOnly = true;
	}

	private void Txt_Pesquisa_TextChanged(object sender, EventArgs e)
	{
		var listaChamada = _chamadaDal.Pesquisa(Txt_Pesquisa.Text);
		dataGridView1.DataSource = listaChamada;
		ConfigurarColunaDataGrid();
	}

	private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		ChamadaId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["IdChamada"].Value);
		Chamada = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Chamada"].Value.ToString();
		DialogResult = DialogResult.OK;
	}
}
