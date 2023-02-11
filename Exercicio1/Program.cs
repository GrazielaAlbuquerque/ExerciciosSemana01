Console.WriteLine("Olá, tudo bem? Qual seu nome?");
string primeiroNome = Console.ReadLine();

Console.WriteLine("Qual seu sobrenome?");
string sobrenome = Console.ReadLine();

Console.WriteLine("Qual sua idade?");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Qual sua cor favorita?");
string cor = Console.ReadLine();

Console.WriteLine($"Meu nome é {primeiroNome} {sobrenome}");
Console.WriteLine($"E tenho {idade} anos");
Console.WriteLine($"Minha cor favorita é {cor}");