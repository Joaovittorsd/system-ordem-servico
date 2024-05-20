using ordemServico.Enums;
using System.ComponentModel.DataAnnotations;

namespace ordemServico.Model;

public class OrdemServicoModel
{
    [Key]
    public int IdOrdemServico { get; set; }
    public Status Status { get; set; }
    public DateTime DataAbertura { get; set; }
    public DateTime? DataFechamento { get; set; }
    public string? HorimetroKm { get; set; }
    public int ChamadaId { get; set; }
    public int VeiculoId { get; set; }
    public int SolicitanteId { get; set; }
    public int UsuarioId { get; set; }

    public virtual ChamadaModel? Chamada { get; set; }
    public virtual VeiculoModel? Veiculo { get; set; }
    public virtual SolicitanteModel? Solicitante { get; set; }
    public virtual UsuarioModel? Usuario { get; set; }
}

