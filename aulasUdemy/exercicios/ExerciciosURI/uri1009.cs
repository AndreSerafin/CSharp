using System;
/*Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas
por ele no mês (em dinheiro). Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas,
informar o total a receber no final do mês, com duas casas decimais.*/
class uri1009{

    private static void Main(){
        string nome;
        double salFixo,totalVendido,sal;
        
        Console.Write("Digite o nome do funcionario: ");
        nome = Console.ReadLine();
        Console.Write("Digite o valor do salario fixo: ");
        salFixo = double.Parse(Console.ReadLine());
        Console.Write("Digite o total vendido: ");
        totalVendido = double.Parse(Console.ReadLine());
        
        sal = salFixo + (totalVendido * 15/100);

        Console.WriteLine("TOTAL = R$ {0}",sal.ToString("F2"));
    }

}