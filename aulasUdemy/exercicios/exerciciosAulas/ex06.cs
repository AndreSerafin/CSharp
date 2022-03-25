using System;
/*Fazer um programa para ler tres numeros inteiros. Em seguida, mostrar qual o menor dentre os três numeros lidos
Em caso de empate, mostrar apenas uma vez.*/
class ex06{
    private static void Main(){
        string[] dados;
        int a,b,c,menor = 0;

        dados = Console.ReadLine().Split(' ');
        a = int.Parse(dados[0]);
        b = int.Parse(dados[1]);
        c = int.Parse(dados[2]);

        if(a < b && a < c){
            menor = a;
        }else if(b < a && b < c){
            menor = b;
        }else{
            menor = c;
        }

        Console.WriteLine("MENOR  = {0}",menor);
    }
}