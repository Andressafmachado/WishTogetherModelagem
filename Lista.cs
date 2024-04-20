namespace Application;
public class Lista {
    public string Titulo { get; set; }
    public string Descrição { get; set; }
    public bool ÉPublica { get; set; }
    public List<Produto> Produtos { get; set; }

    public void AdicionarProduto(Produto produto) {
        Produtos.Add(produto);
    }

    public void RemoverProduto(Produto produto) {
        Produtos.Remove(produto);
    }

    public void MostrarTodasOsProdutos() {
        Console.WriteLine($"Todos os Produtos na lista {Titulo}:");
        foreach (var produto in Produtos)
        {
            Console.WriteLine($"nome: {produto.Nome}, posição: {Produtos.IndexOf(produto)}");
        }
        Console.WriteLine("-----------------");
    }

    public void ReorganizarPosiçãoDoProduto(Produto produto, int novaPosicao){
        Produtos.Remove(produto);
        Produtos.Insert(novaPosicao, produto);
    }

}