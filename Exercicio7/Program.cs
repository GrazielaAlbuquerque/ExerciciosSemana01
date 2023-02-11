Console.WriteLine("Olá, tudo bem? Me informe o nome do aluno a ser avaliado:");
string nomeDoAluno = Console.ReadLine();

Console.WriteLine("Quantos notas serão utilizadas para compor a média?");
int tamanho = int.Parse(Console.ReadLine());

decimal[] notas = new decimal[tamanho];

int i = 0;

  do{
Console.WriteLine("Digite a nota " + (i+1));
  notas[i] = decimal.Parse(Console.ReadLine());
i++;
}while (i < tamanho);
decimal sum = notas.Sum();
decimal mediaNota = sum / tamanho;
Console.WriteLine($"Aluno: {nomeDoAluno}");

for (int j = 0 ; j<tamanho; j++){
  Console.WriteLine($"Nota {j+1}:{notas[j]}");
}
Console.WriteLine($"Média: {mediaNota}");
if (mediaNota >= 6) {
    Console.WriteLine("Aluno Aprovado com Média: " + mediaNota);
    }
else if (mediaNota >= 5 && mediaNota <6){
  Console.WriteLine("Aluno em Recuperação com média: " + mediaNota);
}
else {
  Console.WriteLine("Aluno Reprovado com média: " + mediaNota);
}
