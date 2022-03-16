using System;
/*Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas,
o valor que recebe por hora e calcula o salário desse funcionário. 
A seguir, mostre o número e o salário do funcionário, com duas casas decimais.*/
class uri1008{

    private static void Main(){
        int num,qtddHora;
        double valHora,sal;
        
        Console.Write("Digite o numero do funcionario: ");
        num = int.Parse(Console.ReadLine());
        Console.Write("Digite a quantidade de horas trabalhadas: ");
        qtddHora = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor da hora trabalhada: ");
        valHora = double.Parse(Console.ReadLine());
        sal = qtddHora * valHora;

        Console.WriteLine("NUMBER = {0}",num);
        Console.WriteLine("SALARY = U$ {0}",sal.ToString("F2"));
    }

}