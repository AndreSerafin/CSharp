using System;
/*Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual
o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir
mostre o valor lido e a relação de notas necessárias.*/
class uri015
{

    private static void Main()
    {
        int valor,notas;
        int[] cedulas = new int[7]{100,50,20,10,5,2,1};

        valor = int.Parse(Console.ReadLine()); 
        
        for(int i = 0; i <= 6;i++){
        notas = valor/cedulas[i];
        Console.WriteLine("{0} notas(s) de R$ {1},00",notas,cedulas[i]);
        valor %= cedulas[i];
        }
    }
}