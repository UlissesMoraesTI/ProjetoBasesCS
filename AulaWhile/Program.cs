string senha = "";

while (senha != "1234")
{
    if (senha == "")
    {
        Console.WriteLine("Digite a senha!");
    }
    else
    {
        Console.WriteLine("Senha Inválida! Digite Novamente:");
    }

    senha = Console.ReadLine();
}
Console.WriteLine("Senha correta!");