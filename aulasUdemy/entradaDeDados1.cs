using System;

class entradaDeDados{
    static void Main(string[] args){

        string frase,x,y,z,p0,p1,p2;
        string[] vet;
        
        Console.WriteLine("Digite uma frase: ");
        frase = Console.ReadLine();
        Console.WriteLine("Digite tres cores: ");
        x = Console.ReadLine();
        y = Console.ReadLine();
        z = Console.ReadLine();
        vet = Console.ReadLine().Split(' ');
        p0 = vet[0];
        p1 = vet[1];
        p2 = vet[2];
        Console.WriteLine("Voce digitou \n{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}",frase,x,y,z,p0,p1,p2);
         

    }
}