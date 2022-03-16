using System;
/*Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e 
informe-o expresso no formato horas:minutos:segundos.*/
class uri1019
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