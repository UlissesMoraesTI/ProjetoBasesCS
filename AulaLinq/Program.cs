List<Produto> produtos = new List<Produto>();
produtos.Add(new Produto { Nome = "Notebook", Preco = 3500 });
produtos.Add(new Produto { Nome = "Mouse   ", Preco = 80 });
produtos.Add(new Produto { Nome = "Mouse   ", Preco = 70 });
produtos.Add(new Produto { Nome = "Mouse   ", Preco = 40 });
produtos.Add(new Produto { Nome = "Teclado ", Preco = 150 });
produtos.Add(new Produto { Nome = "Monitor ", Preco = 1200 });
produtos.Add(new Produto { Nome = "Webcam  ", Preco = 200 });

foreach (var produto in produtos)
{
    Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco}");
}

Console.WriteLine("Lista de Produtos Caros:");

var caros = produtos.Where(p => p.Preco > 1000).ToList();

foreach (var produto in caros)
{
    Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco}");
}

Console.WriteLine("Lista de Produto Específicos:");
var webcam = produtos.FirstOrDefault(p => p.Nome.Trim() == "Fone de Ouvido");

Console.WriteLine($"Nome: {webcam?.Nome}, Preço: {webcam?.Preco}");

Console.WriteLine("Produtos Classificados:");

var classificados = produtos
.OrderBy(p => p.Nome)
.ThenBy(p => p.Preco)
.ToList();
foreach (var produto in classificados)
{
    Console.WriteLine($"Nome: {produto.Nome}, Preço: {produto.Preco}");
}

Console.WriteLine("Quantidade de Produtos:");
int quantidade = produtos.Count(p => p.Preco <= 200);

Console.WriteLine($"Quantidade de produtos com preço menor que 200: {quantidade}");

Console.WriteLine("Fim da execução.");

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}
