using System;
//Write a C# Sharp program that takes four numbers as input to calculate and print the average.
class ex009{
    static void Main(){
        double n1,n2,n3,n4,med;

        Console.WriteLine("Digite quatro numeros: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        n2 = Convert.ToDouble(Console.ReadLine());
        n3 = Convert.ToDouble(Console.ReadLine());
        n4 = Convert.ToDouble(Console.ReadLine());

        med = (n1 + n2 + n3 + n4) / 4;

        Console.WriteLine("A media entre {0}, {1}, {2}, {3} é: {4}",n1,n2,n3,n4,med);

    }
}