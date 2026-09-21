List<string> estados = new List<string>();
estados.Add("São Paulo");
estados.Add("Rio de Janeiro");
estados.Add("Minas Gerais");
estados.Add("Brasília");

for (int i = 0; i < estados.Count; i++)
{
    Console.WriteLine(estados[i]);
}

// Removendo Brasília da lista
estados.Remove("Brasília");

