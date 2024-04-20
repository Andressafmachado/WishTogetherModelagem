
namespace Application;

public class Usuario {
    public string Nome { get; set; }
    public DateTime DataDeNascimento { get; set; }
    public string? Endereço { get; set; }
    public List<Lista> Listas { get; set; }
    public List<Produto> Produtos {get; set; }
    public List<Usuario> Amigos { get; set; }
    private IGerenciadorAmizade _amizade {get;set;}


    public void ConvidarAmigo(Usuario eu, Usuario amigo) {
       _amizade.Solicitar(eu,amigo);
    }

    public void AceitarAmizade(Usuario eu, Usuario amigo) {
        /*
        mover para implementação da interface IGerenciadorAmizade;

        if(!AmizadesPendentes.Contains(amigo)){
            Console.WriteLine($"Você ainda não tem uma amizade pendente com {amigo.Nome}, Convide {amigo.Nome} para ser seu amigo primeiro");
            return;
        }


        AmizadesPendentes.Remove(amigo);
        Amigos.Add(amigo);
        amigo.Amigos.Add(eu);
        */
    }

    public void RejeitarAmizade(Usuario amigo) {
        AmizadesPendentes.Remove(amigo);
    }

    public void DesfazerAmizade(Usuario eu, Usuario amigo) {
        Amigos.Remove(amigo);
        amigo.Amigos.Remove(eu);
    }

    public void MostrarAmigos() {
        Console.WriteLine($"Todos os Amigos do usuario {Nome}:");
        foreach (var amigo in Amigos)
        {
            Console.WriteLine($"{amigo.Nome}");
        }
         Console.WriteLine("-----------------");
    }

    public void AdicionarLista(Lista lista){
        Listas.Add(lista);
    }

    public void RemoverLista(Lista lista){
        Listas.Remove(lista);
    }

    public void MostrarTodasAsListas() {
        Console.WriteLine($"Todas as listas do usuario {Nome}:");
        foreach (var lista in Listas)
        {
            Console.WriteLine($"{lista.Titulo}");
        }
        Console.WriteLine("-----------------");
    }

    public Lista CompartilharLista(Lista lista){
        return lista;
    }

    public void VerTodasAsListasDoMeuAmigo(Usuario amigo){
        if(!Amigos.Contains(amigo)){
            Console.WriteLine($"infelizmente vocês ainda não são amigos, convide {amigo.Nome} para ser seu amigo para ter acesso as listas!");
            return;
        }


        Console.WriteLine($"Todas as listas do meu amigo {amigo.Nome}:");
        var listas = amigo.Listas.FindAll(l => l.ÉPublica == true);
        foreach (var lista in listas)
        {
            Console.WriteLine($"{lista.Titulo}");
        }
        Console.WriteLine("-----------------");
    }

    
    public void VerTodosOsProdutosNaListaDoMeuAmigo(Usuario amigo, string nomeDaLista){
        var lista = amigo.Listas.Single(l => l.Titulo == nomeDaLista);
        var produtosDisponiveis = lista.Produtos.FindAll(p => p.status == Status.disponivel);
        Console.WriteLine($"Todas os produtos da lista {lista.Titulo}, do amigo {amigo.Nome}:");
        foreach (var produto in produtosDisponiveis)
        {
            Console.WriteLine($"{lista.Titulo}");
        }
        Console.WriteLine("-----------------");
    }

    private DateTime dataProdutoReivindicado;

    public void ReivindicarProdutoNaListaDoMeuAmigo(Usuario amigo, Produto produto){
        if(!amigo.Produtos.Contains(produto)){
            Console.WriteLine($"{amigo.Nome} não possui o produto {produto.Nome}");
            return;
        }
        produto.status = Status.reivindicado;
        dataProdutoReivindicado = new DateTime(); // depois de 30 dias produto vai mudar status pra removido
    }

    public void AdicionarProduto(Produto produto){
        Produtos.Add(produto);
    }

    public void RemoverProduto(Produto produto){
        Produtos.Remove(produto);
    }



}