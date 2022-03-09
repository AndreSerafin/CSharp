using System;
/*Faça um programa que leia três valores e apresente
 o maior dos três valores lidos seguido da mensagem “eh o maior”.*/
class uri010{

    private static void Main(){

        int a,b,c,maior;
        string[] dados;

        dados = Console.ReadLine().Split(' ');

        a = int.Parse(dados[0]);
        b = int.Parse(dados[1]);
        c = int.Parse(dados[2]);

        maior = a;
        
        if(b > a && b > c){
            maior = b;
        }else if(c > b && c > a){
            maior = c;
        }

        Console.WriteLine("{0} eh o maior",maior);

    }

}