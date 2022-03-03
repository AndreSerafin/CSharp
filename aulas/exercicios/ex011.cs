using System;
//Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20"
class ex011{
    static void Main(){
        int idade;

        Console.Write("Qual é sua idade?: ");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.Write("Você parece ter mais do que {0}",idade);

    }
}