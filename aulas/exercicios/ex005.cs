using System;

class ex005{
    static void Main(){
        
        int n1,n2,aux;

        Console.WriteLine("Digite dois numeros: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());
        aux = n1;
        n1 = n2;
        n2 = aux;
        Console.Write("Primeiro numero: {0}\nSegundo numero: {1}",n1,n2);

    }
}