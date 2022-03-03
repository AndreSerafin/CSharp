using System;
//Write a C# Sharp program to print the sum of two numbers.
class ex002{
    static void Main(){

        int n1,n2,soma;

        Console.Write("Digite dois numeros: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());
        soma = n1 + n2;
        Console.Write("A soma de {0} mais {1} e igual a: {2}",n1,n2,soma);

    }
}