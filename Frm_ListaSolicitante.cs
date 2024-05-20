using ordemServico.DAL;
using ordemServico.Database;
using ordemServico.Model;

namespace ordemServico;

public partial class Frm_ListaSolicitante : Form
{
	private GsoContext _context;
	private DAL<SolicitanteModel> _solicitanteDal;

	public int SolicitanteId { get; private set; }
	public string? Nome { get; private set; }

	public Frm_ListaSolicitante()
	{
		_context = new GsoContext();
		_solicitanteDal = new DAL<SolicitanteModel>(_context);

		InitializeComponent();
	}

	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);

		var listaSolicitante = _solicitanteDal.Listar();
		if (listaSolicitante == null) return;
		dataGridView1.DataSource = listaSolicitante;
		ConfigurarColunaDataGrid();
	}

	private void ConfigurarColunaDataGrid()
	{
		dataGridView1.Columns["IdSolicitante"].HeaderText = "Registro";
		dataGridView1.Columns["IdSolicitante"].Width = 120;
		dataGridView1.Columns["IdSolicitante"].ReadOnly = true;

		dataGridView1.Columns["Nome"].HeaderText = "Solicitante";
		dataGridView1.Columns["Nome"].Width = 250;
		dataGridView1.Columns["Nome"].ReadOnly = true;
	}

	private void Txt_Pesquisa_TextChanged(object sender, EventArgs e)
	{
		var listaSolicitante = _solicitanteDal.Pesquisa(Txt_Pesquisa.Text);
		dataGridView1.DataSource = listaSolicitante;
		ConfigurarColunaDataGrid();
	}

	private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		SolicitanteId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["IdSolicitante"].Value);
		Nome = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Nome"].Value.ToString();
		DialogResult = DialogResult.OK;
	}
}
