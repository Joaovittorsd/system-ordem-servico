using MySqlConnector;
using ordemServico.DAL;
using ordemServico.Database;
using ordemServico.Model;

namespace ordemServico;

public partial class Frm_Login : Form
{
	private GsoContext _context;
	private DAL<UsuarioModel> _usuarioDal;

	public Frm_Login()
	{
		_context = new GsoContext();
		_usuarioDal = new DAL<UsuarioModel>(_context);
		InitializeComponent();
	}

	private void Btn_Entrar_Click(object sender, EventArgs e)
	{
		try
		{
			string username = Txt_Username.Text;
			string password = Txt_Password.Text;

			if (string.IsNullOrEmpty(username))
			{
				MessageBox.Show("Por favor, preencha o campo do usuário, ele não pode ficar vazio.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			if (string.IsNullOrEmpty(password))
			{
				MessageBox.Show("Por favor, preencha o campo da senha, ele não pode ficar vazio.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			var usuarioEncontrado = _usuarioDal.RecuperarPor(null, u => u.UserName == username);
			AutenticarUsuario(usuarioEncontrado);
		}
		catch (MySqlException ex)
		{
			MessageBox.Show($"Error: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	private void AutenticarUsuario(IEnumerable<UsuarioModel> usuarioEncontrado)
	{
		string digSenha = Txt_Password.Text;

		if (usuarioEncontrado.Count() == 0)
		{
			MessageBox.Show("Usuário não encontrado!", "SENHA", MessageBoxButtons.OK, MessageBoxIcon.Information);
			return;
		}

		foreach (var usuario in usuarioEncontrado)
		{
			if (usuario.PassWord == digSenha)
			{
				var frmMenu = new Frm_Menu(usuarioEncontrado);
				Hide();
				frmMenu.Show();
			}
			else
			{
				MessageBox.Show("Senha Incorreta", "SENHA", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
		}
	}

	private void Btn_Cancelar_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}
}
