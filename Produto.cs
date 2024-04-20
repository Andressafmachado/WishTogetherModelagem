namespace Application;
public class Produto {
    public string Nome { get; set; }
    public string? Tamanho { get; set; }
    public string? Cor { get; set; }
    public string? Link { get; set; }
    public string? Imagem { get; set; }
    // posso add valor default?
    public int? Quantidade { get; set; } = 1;
    public int Posição { get; set; }
    public Status status {get; set;}

}

public enum Status
{
    disponivel,
    reivindicado,
    removido
}