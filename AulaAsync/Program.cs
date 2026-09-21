File.WriteAllText("logAplicacao.txt", "Iniciando Log da Aplicação");

await LerArquivoAsync();

Console.WriteLine("Lendo arquivo de log...");

async Task LerArquivoAsync()
{
    string caminho = "logAplicacao.txt";
    string conteudo = await File.ReadAllTextAsync(caminho);
    Console.WriteLine(conteudo);
}

Console.WriteLine("Programa finalizado com sucesso!.");



/*Console.WriteLine("Digite a Opção:");

MetodoDemoradoAsync();

string opcao;

while ((opcao = Console.ReadLine()) != "x" && opcao != "X")
{
    Console.WriteLine($"Opção digitada: {opcao}");
}

async Task MetodoDemoradoAsync()
{
    Console.WriteLine("Iniciando método demorado...");
    await Task.Delay(10000); // Simula um processamento demorado
    Console.WriteLine("Método demorado finalizado.");
}

Console.WriteLine("Programa encerrado.");


*/