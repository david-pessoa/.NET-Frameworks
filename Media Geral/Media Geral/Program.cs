using Media_Geral;

Console.Title = "Títulinho";
Console.Write("N° de alunos a cadastrar: ");
int num_Alunos = int.Parse(Console.ReadLine());
Console.WriteLine(); // Quebra de linha
Aluno[] alunos = new Aluno[num_Alunos];

for (int i = 0; i < num_Alunos; i++)
{
    Console.Write($"Aluno #{i + 1}. Digite o nome: ");
    string nome = Console.ReadLine();

    Console.Write($"Aluno #{i + 1}. Provas: ");
    int provas = int.Parse(Console.ReadLine());
    alunos[i] = new Aluno(nome, provas);

    Console.WriteLine("Insira as notas do aluno "+ nome);
    alunos[i].InserirNotas();
    Console.Clear();
}

double mediaGeral = 0;
foreach (Aluno aluno in alunos)
{
    Console.WriteLine("Aluno: " + aluno.Nome);
    Console.WriteLine("Media: " + aluno.Media);
    Console.WriteLine(); // Quebra de linha
    mediaGeral += aluno.Media;
}

double resultadoFinal = mediaGeral / num_Alunos;
Console.WriteLine($"Média Geral dos alunos: {resultadoFinal}");



