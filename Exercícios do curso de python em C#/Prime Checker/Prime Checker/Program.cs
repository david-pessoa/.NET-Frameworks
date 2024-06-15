using Prime;

Console.Write("Check if this number is prime: ");
int n = int.Parse(Console.ReadLine());
Primo primo = new Primo();
string answer = primo.prime_checker(n);
Console.WriteLine(answer);
