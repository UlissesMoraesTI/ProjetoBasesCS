//gravar linha por linha no arquivo
using (StreamWriter sw = new StreamWriter(@"C:\FTPB\exemplo_stream.txt"))
{
    sw.WriteLine("Registro 1");
    sw.WriteLine("Registro 2");
    sw.WriteLine("Registro 3");
}

//ler o arquivo linha por linha
using (StreamReader sr = new StreamReader(@"C:\FTPB\exemplo_stream.txt"))
{
    string linha;
    while ((linha = sr.ReadLine()) != null)
    {
        Console.WriteLine(linha);
    }
}


try
{
    File.Delete(@"C:\EssaPastaNaoExiste\exemplo_delete.txt");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro ao excluir o arquivo: {ex.Message}");
}

