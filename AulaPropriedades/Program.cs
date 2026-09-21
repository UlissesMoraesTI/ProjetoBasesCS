using System;

class Produto
{
    private double preco;

    public double Preco
    {
        get { return preco; }
        set
        {
            if (value > 0)
            {
                preco = value;
            }
            else
            {
                Console.WriteLine("Preço inválido.");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Produto p = new Produto();

        p.Preco = 100;   // válido
        Console.WriteLine($"Preço: {p.Preco}");

        p.Preco = -50;   // inválido
        Console.WriteLine($"Preço: {p.Preco}");
    }
}
