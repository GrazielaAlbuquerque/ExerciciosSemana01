Console.WriteLine ("Olá, vamos aprender a tabuada? Com qual número você quer começar?");
int tabuada = int.Parse(Console.ReadLine());


Console.WriteLine("O resultado da desta tabuada é: ");

//int tabuada = Console.ReadLine();

for ( int i = 1; i <= 10; i++) {

int resultado = (i)* tabuada;

Console.WriteLine(tabuada + "x" + i + "=" + i*tabuada);
};