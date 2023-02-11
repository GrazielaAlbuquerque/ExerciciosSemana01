
Console.WriteLine("Olá, vamos descobrir se temos umtriângulo! Para isso me informe a medida do primeiro lado:");
int lado1 = int.Parse(Console.ReadLine());
Console.WriteLine($"Digite o segundo lado:");
int lado2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Digite o terceiro lado:");
int lado3 = int.Parse(Console.ReadLine());

if (lado1 == lado2 && lado2 == lado3 && lado3 == lado1) {
    Console.WriteLine("Temos um triângulo Equilátero.");
    }
else if (lado1==lado2 || lado2==lado3 || lado3==lado1) {
  Console.WriteLine("Temos um triângulo Isósceles.");
}
else if (lado1!=lado2 && lado2!=lado3 && lado3!=lado1){
  Console.WriteLine("Temos um triângulo Escaleno."); }

  else {
    Console.WriteLine("As medidas informandas não formam um triângulo.");
  }