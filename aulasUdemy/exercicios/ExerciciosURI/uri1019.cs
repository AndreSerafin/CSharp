using System;
using System.Globalization;
/*Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. 
A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. 
As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01.
 A seguir mostre a relação de notas necessárias.*/
class uri015
{

    private static void Main()
    {
        double valor,qtddNotas,qtddMoedas;
        int[] cedulas = new int[]{100,50,20,10,5,2};
        double[] moedas = new double[]{1.0,0.5,0.25,0.10,0.05,0.01};

        valor = double.Parse(Console.ReadLine()); 
        
        Console.WriteLine("NOTAS:");
        for(int i = 0; i <= 5;i++){
        qtddNotas = valor/cedulas[i];
        Console.WriteLine("{0} notas(s) de R$ {1}",(int) qtddNotas,cedulas[i].ToString("F2"));
        valor %= cedulas[i];
        }

        Console.WriteLine("MOEDAS:");
        for(int i = 0;i <= 5;i++){
            qtddMoedas = valor/moedas[i];
            Console.WriteLine("{0} moeda(s) de R$ {1}",(int) qtddMoedas,moedas[i].ToString("F2"));
            valor %= moedas[i];
        }
    }
}