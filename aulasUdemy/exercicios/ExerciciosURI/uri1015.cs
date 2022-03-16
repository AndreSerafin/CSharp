using System;
/*Leia os quatro valores correspondentes aos eixos x e y de dois pontos quaisquer no plano, p1(x1,y1) e p2(x2,y2) e 
calcule a distância entre eles, mostrando 4 casas decimais após a vírgula, segundo a fórmula:*/
class uri1015{

    private static void Main(){

        double x1,x2,y1,y2,dist;
        string[] dados1, dados2;

        dados1 = Console.ReadLine().Split(' ');
        dados2 = Console.ReadLine().Split(' ');
        
        x1 = double.Parse(dados1[0]);
        x2 = double.Parse(dados1[1]);
        y1 = double.Parse(dados2[0]);
        y2 = double.Parse(dados2[1]);

        dist = Math.Sqrt(Math.Pow((x2 - x1), 2.0) + Math.Pow((y2 - y1), 2.0));

        Console.WriteLine("{0}",dist.ToString("F4"));
    }

}