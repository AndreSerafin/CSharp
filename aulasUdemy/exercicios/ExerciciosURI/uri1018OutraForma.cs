using System;
/*Leia um valor inteiro. A seguir. calcule o menor número de notas possíveis (cédulas) no qual
o valor pode ser decomposto. As notas consideradas são de 100. 50. 20. 10. 5. 2 e 1. A seguir
mostre o valor lido e a relação de notas necessárias.*/
class uri1018OutraForma
{

    private static void Main()
    {
        int valor,notas;
        valor = int.Parse(Console.ReadLine());
        
        notas = valor/100;
        valor %= 100;
        Console.WriteLine("{0} nota(s) de R$ 100.00",notas);
        
        notas = valor/50;
        valor %= 50;
        Console.WriteLine("{0} nota(s) de R$ 50.00",notas);
        
        notas = valor/20;
        valor %= 20;
        Console.WriteLine("{0} nota(s) de R$ 20.00",notas);
        
        notas = valor/10;
        valor %= 10;
        Console.WriteLine("{0} nota(s) de R$ 10.00",notas);
        
        notas = valor/5;
        valor %= 5;
        Console.WriteLine("{0} nota(s) de R$ 5.00",notas);
        
        notas = valor/2;
        valor %= 2;
        Console.WriteLine("{0} nota(s) de R$ 2.00",notas);
        
        notas = valor/1;
        valor %= 1;
        Console.WriteLine("{0} nota(s) de R$ 1.00",notas);
        

    }
}