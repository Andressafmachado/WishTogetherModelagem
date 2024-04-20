namespace Application;
var luiz = new Usuario();
luiz.Nome = "Luiz";
luiz.DataDeNascimento = new DateTime(10/10/1980);
luiz.Amigos = [];
luiz.Listas = [];
luiz.Produtos = [];
//luiz.AmizadesPendentes = [];

var usuarios = new List<Usuario>(); // endereço 456 na heap;

var andressa = new Usuario(); //endereço 123 na heap;

// usuarios.Add(andressa)///
andressa.Nome = "Andressa";
andressa.DataDeNascimento = new DateTime(10/10/1980);
andressa.Amigos = [];
andressa.Listas = [];
andressa.Produtos = [];
//andressa.AmizadesPendentes = [];

var fernanda = new Usuario();
fernanda.Nome = "Fernanda";
fernanda.DataDeNascimento = new DateTime(10/10/1980);
fernanda.Amigos = [];
fernanda.Listas = [];
fernanda.Produtos = [];
//fernanda.AmizadesPendentes = [];

var boardGames = new Lista();
boardGames.Titulo = "Games";
boardGames.Descrição = "board games que eu quero comprar";
boardGames.ÉPublica = true;
boardGames.Produtos = [];

var marvel = new Produto();
marvel.Nome = "Marvel Board Game";
marvel.Posição = 1;

var dc = new Produto();
dc.Nome = "DC Board Game";
dc.Posição = 2; // como fazer ser unico?

var listaPrivada = new Lista();
listaPrivada.Titulo = "Minhas coisas privadas";
listaPrivada.ÉPublica = false;
listaPrivada.Produtos = [];


andressa.ConvidarAmigo(andressa, luiz);
luiz.AceitarAmizade(luiz, andressa);
luiz.AceitarAmizade(luiz, fernanda);
luiz.MostrarAmigos();
andressa.MostrarAmigos();

luiz.AdicionarLista(boardGames);
luiz.AdicionarLista(listaPrivada);
luiz.AdicionarProduto(marvel);
boardGames.AdicionarProduto(marvel);
luiz.AdicionarProduto(dc);
boardGames.AdicionarProduto(dc);
listaPrivada.AdicionarProduto(marvel);

luiz.MostrarTodasAsListas();
boardGames.MostrarTodasOsProdutos();
boardGames.ReorganizarPosiçãoDoProduto(dc, 0);

boardGames.MostrarTodasOsProdutos();

andressa.VerTodasAsListasDoMeuAmigo(luiz);
fernanda.VerTodasAsListasDoMeuAmigo(andressa);

andressa.ReivindicarProdutoNaListaDoMeuAmigo(luiz, marvel);



