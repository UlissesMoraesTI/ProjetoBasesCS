class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa("João", 30);
        Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}");
    }
}