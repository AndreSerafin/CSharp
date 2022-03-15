using System;
using System.Globalization;
/*Fazer um programa para ler as medidas da base e altura de um retângulo. Em
seguida, mostrar o valor da área, perímetro e diagonal deste retângulo, com quatro
casas decimais, conforme exemplo*/
class ex03
{

    private static void Main(){

        int bas,alt;
        double area,perim,diag;
        string[] dados;

        Console.WriteLine("Digite o valor da Base e a Altura do retângulo: ");
        dados = Console.ReadLine().Split(' ');

        bas = int.Parse(dados[0],CultureInfo.InvariantCulture);
        alt = int.Parse(dados[1],CultureInfo.InvariantCulture);

        area = bas * alt;
        perim = (bas * 2.0) + (alt * 2.0);
        diag = Math.Sqrt((bas * bas) + (alt * alt));

        Console.WriteLine("AREA = {0}",area.ToString("F4",CultureInfo.InvariantCulture));
        Console.WriteLine("PERIMETRO = {0}",perim.ToString("F4",CultureInfo.InvariantCulture));
        Console.WriteLine("DIAGONAL = {0}",diag.ToString("F4",CultureInfo.InvariantCulture));
    }

}