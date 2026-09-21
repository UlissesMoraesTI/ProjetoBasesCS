Console.WriteLine("Digite um número:");

//Tente isso com um bloco try-catch
try
{
    int numero = int.Parse(Console.ReadLine());
    Console.WriteLine($"Você digitou: {numero}");

    var resultado = numero / 0;
}
//Capture a exceção
catch (FormatException)
{
    Console.WriteLine("Você não digitou um número válido.");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Ocorreu uma divisão por zero.");
}
catch (Exception)
{
    Console.WriteLine("Ocorreu um erro inesperado. Tente novamente.");
}
//Vai passar aqui independentemente de ter ocorrido uma exceção ou não
finally
{
    Console.WriteLine("Fim da execução.");
}