

double salarioBruto;
Console.WriteLine("Olá! Vamos calcular o imposto sobre a sua folha de pagamento. Para isso, digite o valor do seu salário bruto:");
salarioBruto = double.Parse(Console.ReadLine());

if (salarioBruto <= 900) {
    Console.WriteLine("ISento de Imposto");
    }
else if (salarioBruto >=901  && salarioBruto <=1500){
  Console.WriteLine("Imposto R$" + (salarioBruto/100*5));
}
else if (salarioBruto >=1501  && salarioBruto <=2499) {
  Console.WriteLine("Imposto R$" + (salarioBruto/100*10));
}

else if (salarioBruto >=2500) {
  Console.WriteLine("Imposto R$" + (salarioBruto/100*20));
}


