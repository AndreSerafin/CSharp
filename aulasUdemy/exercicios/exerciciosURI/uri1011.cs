using System;
class uri1011{
    private static void Main(){

        double vol,raio,pi = 3.14159;

        raio = double.Parse(Console.ReadLine());

        vol = (4/3.0) * pi * Math.Pow(raio,3);

        Console.WriteLine("VOLUME = {0}", vol.ToString("F3"));

    }
}