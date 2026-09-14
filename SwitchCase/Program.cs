Console.WriteLine("1 - Solteiro");
Console.WriteLine("2 - Casado");
Console.WriteLine("3 - Separado");
Console.WriteLine("4 - Divorciado");
Console.WriteLine("5 - Viúvo");
Console.WriteLine("6 - União Estável");

Console.Write("Digite a opção desejada: ");
string opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
        Console.WriteLine("Você escolheu Solteiro");
        break;
    case "2":
        Console.WriteLine("Você escolheu Casado");
        break;
    case "3":
        Console.WriteLine("Você escolheu Separado");
        break;
    case "4":
        Console.WriteLine("Você escolheu Divorciado");
        break;
    case "5":
        Console.WriteLine("Você escolheu Viúvo");
        break;
    case "6":
        Console.WriteLine("Você escolheu União Estável");
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}

