using System.ComponentModel.DataAnnotations;

namespace ordemServico.Model;

public class VeiculoModel
{
    [Key]
    public int IdVeiculo { get; set; }
    public string Prefixo { get; set; }
    public string Placa { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
}
