using System;
/*Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual
o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir
mostre o valor lido e a relação de notas necessárias.*/
class uri015
{

    private static void Main()
    {
        
        int seg,hora,min;

        seg = int.Parse(Console.ReadLine());

        hora = seg/3600;
        seg %= 3600;
        
        min = seg/60;
        seg %= 60;
        Console.WriteLine("{0}:{1}:{2}",hora,min,seg);
    
    
        
    }
}