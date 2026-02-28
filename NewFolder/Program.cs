class Program {

struct Pessoa
{
  public string nome;
  public int idade;
  public double altura;
}
static void Main(string[] args)
{
  Pessoa p2 = new Pessoa{
    nome = "Arthur", idade = 9, altura = 1.35
  };

  Console.WriteLine(p2.nome);
}
}
