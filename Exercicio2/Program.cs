Console.WriteLine("Olá, vamos calcular a área de um triângulo juntos? Por favor me informe a valor da base e da altura.");

Console.WriteLine("Base: ");
decimal baseDoTriangulo = decimal.Parse(Console.ReadLine());

Console.WriteLine("Altura: ");
decimal alturaDoTriangulo = decimal.Parse(Console.ReadLine());

decimal area = (baseDoTriangulo*alturaDoTriangulo)/2;

Console.WriteLine($"A área do nosso triângulo é {area} cm.");
