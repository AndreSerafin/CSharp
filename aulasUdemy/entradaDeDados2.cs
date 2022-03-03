using System;

class entradaDeDados{
    static void Main(string[] args){

        int n1,idd;
        char ch,sx;
        double n2,alt;
        string[] v;
        string nome;

        Console.Write("Digite um numero inteiro: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite um caractere: ");
        ch = Convert.ToChar(Console.ReadLine());

        Console.Write("Digite um double: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite seu nome, sexo, idade e altura. Separados por espaço: ");
        v = Console.ReadLine().Split(' ');

        nome = v[0];
        sx = Convert.ToChar(v[1]);
        idd = Convert.ToInt32(v[2]);
        alt = Convert.ToDouble(v[3]);
        

        Console.WriteLine("Dados digitados:\n{0}\n{1}\n{2}\n{3}",nome,sx,idd,alt);

    }
}