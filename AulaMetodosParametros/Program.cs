string nome1 = "Ulisses Moraes";
int idade1 = 51;
MostrarNome(nome1, idade1);

string nome2 = "Pedro de Lara";
int idade2 = 80;
MostrarNome(nome2, idade2);

static void MostrarNome(string nome, int idade)
{
    Console.WriteLine("Olá, " + nome + ", você tem " + idade + " anos de idade.");
}
