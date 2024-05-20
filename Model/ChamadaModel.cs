using System.ComponentModel.DataAnnotations;

namespace ordemServico.Model;

public class ChamadaModel
{
    [Key]
    public int IdChamada { get; set; }
    public string Chamada { get; set; }
}
