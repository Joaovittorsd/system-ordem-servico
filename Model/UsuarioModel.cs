using ordemServico.Enums;
using System.ComponentModel.DataAnnotations;

namespace ordemServico.Model;

public class UsuarioModel
{
	[Key]
	public int IdUsuario { get; set; }
	public string Nome { get; set; }
	public string Email { get; set; }
	public string Departamento { get; set; }
	public string UserName { get; set; }
	public string PassWord { get; set; }
	public Perfil? Perfil { get; set; }
}
