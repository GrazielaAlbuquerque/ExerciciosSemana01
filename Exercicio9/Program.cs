List<double> transacao = new List<double>();
string opcao;

do{
    Console.WriteLine("Bem vindp ao Banco Nacional Coqueiros, por favor escolha uma opção:");
    Console.WriteLine("1. Adicionar Transação");
    Console.WriteLine("2. Consultar Extrato");
    Console.WriteLine("3. Sair");
    opcao = Console.ReadLine();

if(opcao == "1"){
    Console.WriteLine("Digite o valor a ser depositado R$:");
    double valor = double.Parse(Console.ReadLine());
    transacao.Add(valor);
}

if (opcao == "2") {
    Console.WriteLine ("Seu Extrato é R$: ");
    double saldo = 0;
    foreach (var valor in transacao){
        saldo = saldo + valor;
        Console.WriteLine($"R$" + valor);
    }
    Console.WriteLine ("O saldo total da sua conta R$" + saldo);
}
} while ((!(opcao == "3")));