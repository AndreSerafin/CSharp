using System;
/*Neste problema, deve-se ler o código de uma peça 1, 
o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, 
o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.*/
class uri008{

    static void Main(){

        int cod1,cod2,np1,np2;
        double valP1,valP2,total;
        string[] dados1,dados2;
        
        dados1 = Console.ReadLine().Split(' ');
        dados2 =Console.ReadLine().Split(' ');

        cod1 = int.Parse(dados1[0]);
        np1 = int.Parse(dados1[1]);
        valP1 = double.Parse(dados1[2]);
        
        cod2 = int.Parse(dados2[0]);
        np2 = int.Parse(dados2[1]);
        valP2 = double.Parse(dados2[2]);

        total = (valP1 * np1) + (valP2 * np2);
        
        Console.WriteLine("VALOR A PAGAR: R$ {0}",total.ToString("F2"));

    }

}