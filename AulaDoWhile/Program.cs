int numero;

do
{
    Console.WriteLine("Digite um número de 1 a 5:");
    numero = int.Parse(Console.ReadLine());
} while (numero < 1 || numero > 5);

Console.WriteLine("Número válido! " + numero);
