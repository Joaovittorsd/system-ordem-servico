using System.ComponentModel.DataAnnotations;

namespace ordemServico.Model;

public class SolicitanteModel
{
    [Key]
    public int IdSolicitante { get; set; }
    public string Nome { get; set; }
}
