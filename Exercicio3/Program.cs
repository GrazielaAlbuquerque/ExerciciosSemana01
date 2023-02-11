Console.WriteLine("Olá, tudo bem? Me informe o nome do aluno a ser avaliado:");
string nomeDoAluno = Console.ReadLine();

Console.WriteLine($"Digite a primeira nota:");
decimal nota1 = decimal.Parse(Console.ReadLine());
Console.WriteLine($"Digite a segunda nota:");
decimal nota2 = decimal.Parse(Console.ReadLine());
Console.WriteLine($"Digite a segunda nota:");
decimal nota3 = decimal.Parse(Console.ReadLine());

decimal mediaNota = (nota1 + nota2 + nota3)/3;
if (mediaNota >= 6) {
    Console.WriteLine("Aluno Aprovado com Média: " + mediaNota);
    }
else if (mediaNota >= 5 && mediaNota <6){
  Console.WriteLine("Aluno em Recuperação com média: " + mediaNota);
}
else {
  Console.WriteLine("Aluno Reprovado com média: " + mediaNota);
}
