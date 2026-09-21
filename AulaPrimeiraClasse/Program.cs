//Objeto da classe Pessoa
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "João";
pessoa1.Idade = 30;
pessoa1.Apresentar();

class Pessoa
{
    //Atributos da classe Pessoa (Características/Propriedades)
    public string Nome { get; set; }
    public int Idade { get; set; }

    //Métodos da classe (Comportamentos/Ações)
    public void Apresentar()
    {
        Console.WriteLine("Olá, meu nome é " + Nome + " e eu tenho " + Idade + " anos.");
    }
}