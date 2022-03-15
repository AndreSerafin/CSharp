using System;
/*Calcule o consumo médio de um automóvel sendo fornecidos a distância total 
percorrida (em Km) e o total de combustível gasto (em litros)..*/
class uri011{

    private static void Main(){

        int x;
        double y,consMed;
        
        x = int.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        consMed = x/y;

        Console.WriteLine("{0} km/l",consMed.ToString("F3"));

    }

}