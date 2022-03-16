using System;
/*Joaozinho quer calcular e mostrar a quantidade de litros de combustível gastos em uma viagem, 
ao utilizar um automóvel que faz 12 KM/L. Para isso, ele gostaria que você o auxiliasse através de um simples 
programa. Para efetuar o cálculo, deve-se fornecer o tempo gasto na viagem (em horas) e a velocidade 
média durante a mesma (em km/h). Assim, pode-se obter distância percorrida e, em seguida, 
calcular quantos litros seriam necessários. Mostre o valor com 3 casas decimais após o ponto.*/
class uri1017
{

    private static void Main()
    {
        int hora,velocMedia;
        double dist,litros;

        hora = int.Parse(Console.ReadLine());
        velocMedia = int.Parse(Console.ReadLine());

        dist = velocMedia*hora;
        litros = dist/12;

        Console.WriteLine("{0}",litros.ToString("F3"));
    }
}