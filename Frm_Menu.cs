using ordemServico.Enums;
using ordemServico.Model;

namespace ordemServico;

public partial class Frm_Menu : Form
{
	private readonly UsuarioModel _usuario;
	public Frm_Menu(IEnumerable<UsuarioModel> usuario)
	{
		InitializeComponent();
		_usuario = usuario.FirstOrDefault();

		Lbl_UsuarioLogado.Text = _usuario.Nome;
		ConfigurarMenu();
	}

	private void ConfigurarMenu()
	{
		if (_usuario.Perfil != Perfil.Administrador)
		{
			cadastroToolStripMenuItem.Enabled = false;
		}
	}

	private void ordemDeServicoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		var frm = new Frm_OrdemServico(_usuario);
		frm.ShowDialog();
	}

	private void Frm_Menu_FormClosing(object sender, FormClosingEventArgs e)
	{
		Environment.Exit(0);
	}
}
