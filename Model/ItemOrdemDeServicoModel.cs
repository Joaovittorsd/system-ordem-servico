using System.ComponentModel.DataAnnotations;

namespace ordemServico.Model;

public class ItemOrdemDeServicoModel
{
    [Key]
    public int IdItemOrdemServico { get; set; }
    public string? ProblemaEncontrado { get; set; }
    public string? AcaoTomada { get; set; }
    public string? Observacao { get; set; }
    public int OrdemServicoId { get; set; }

    public virtual OrdemServicoModel? OrdemServico { get; set; }
}
