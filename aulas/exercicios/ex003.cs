using System;
//Write a C# Sharp program to print the result of dividing two numbers.
class ex003{
    static void Main(){

        int n1,n2,div;

        Console.Write("Digite dois numeros: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());
        div = n1 / n2;
        Console.Write("A divisao de {0} por {1} e igual a: {2}",n1,n2,div);

    }
}