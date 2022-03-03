using System;
//Write a C# Sharp program that takes a number as input and print its multiplication table.

class ex008{
    static void Main(){
        int n1,n2,mult;

        Console.Write("Digite um numero para saber sua tabuada: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = 0;
        for(int i=0;i<=50;i++){
            
            mult = n1 * n2;
            n2++;
            Console.WriteLine("{0} * {1} = {2}",n1,n2,mult);
        }

    }
}