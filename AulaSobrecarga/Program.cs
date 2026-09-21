Calculadora calc = new Calculadora();
int Resultado = calc.Somar(3, 4);
Console.WriteLine(Resultado);

Calculadora calc2 = new Calculadora();
double Resultado2 = calc.Somar(10.10, 20.20);
Console.WriteLine(Resultado2);


class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public double Somar(double a, double b)
    {
        return a + b;
    }
}