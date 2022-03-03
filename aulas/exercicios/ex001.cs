using System;
//Write a C# Sharp program to print Hello and your name in a separate line.
class ex001{
    static void Main(){

        string nome;

        Console.Write("Digite o seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Olá {0}",nome);

    }
}