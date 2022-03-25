using System;

/*Leia 4 valores inteiros A, B, C e D. A seguir, se B for maior do que C e se D for maior do que A, 
e a soma de C com D for maior que a soma de A e B e se C e D, ambos, forem positivos e se a variável 
A for par escrever a mensagem "Valores aceitos", senão escrever "Valores nao aceitos".*/

class uri1035{
    private static void Main(){

        int a,b,c,d;
        string[] dados;

        dados = Console.ReadLine().Split(' ');
        a = int.Parse(dados[0]);
        b = int.Parse(dados[1]);
        c = int.Parse(dados[2]);
        d = int.Parse(dados[3]);

        if(b > c && d > a && c + d > a + b && c > 0 && d > 0 && a % 2 == 0){
            Console.WriteLine("Valores aceitos");

        }else{
            Console.WriteLine("Valores nao aceitos");
        }


    }
}