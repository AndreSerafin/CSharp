using System;
/*Calcule o consumo médio de um automóvel sendo fornecidos a distância total 
percorrida (em Km) e o total de combustível gasto (em litros)..*/
class test{

    private static void Main(){

        int n1;
        double s = 0;

        Console.WriteLine("Digite o valor de N: ");
        n1 = int.Parse(Console.ReadLine());

        for(int i = 1;i <= n1;i++){
            s+= (Math.Pow(i,2) + 1)/(i + 3);
        }
        
        Console.WriteLine("{0}",s.ToString("F4"));

    }

}