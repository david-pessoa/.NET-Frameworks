using Polimorfismo;

Forma f = new Forma();
Circulo c = new Circulo();
Forma d = new Circulo(); // Isso acontece porque a classe Circulo é herdeira de Forma, logo Circulo também é uma Forma.
Console.WriteLine("Forma: ");
f.Desenhar();
c.Circulos();
//NumberGenerator num = new NumberGenerator();
//int numero = num.GetNumber(-1);
//Console.WriteLine(numero);


