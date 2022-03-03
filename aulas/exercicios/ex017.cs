using System;
//Write a C# program to check two given integers and return true if one is negative and one is positive.
class ex016
{
    static void Main()
    {
        int n1,n2;

        Console.WriteLine("Escreva dois numeros: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());

        if(n1 > 0 && n2 < 0){
            Console.WriteLine("Verdadeiro");
        }else{
            Console.WriteLine("Falso");
        }

    }
}