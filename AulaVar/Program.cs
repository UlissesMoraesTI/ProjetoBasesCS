const double PI = 3.14159;

Contador contador1 = new Contador();
Contador contador2 = new Contador();
Contador contador3 = new Contador();

//variável nível de classe
Console.WriteLine("Total de objetos criados: " + Contador.TotalDeObjetosCriados);

class Contador
{
    public static int TotalDeObjetosCriados = 0;

    public Contador()
    {
        TotalDeObjetosCriados = TotalDeObjetosCriados + 1;
    }
}



