using System;

/*Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for 
possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, caso haja uma divisão 
por 0 ou raiz de numero negativo.*/

class uri1036{
    private static void Main(){
        double a,b,c,delta,x1=0,x2=0;
        string[] dados;

        dados = Console.ReadLine().Split(' ');

        a = double.Parse(dados[0]);
        b = double.Parse(dados[1]);
        c = double.Parse(dados[2]);

        delta = Math.Pow(b,2.0) - 4*a*c;

        if(a == 0 || delta < 0){
            Console.WriteLine("Impossivel calcular");
        }else{
            x1 = (-(b) + Math.Sqrt(delta))/(2 * a);
            x2 = (-(b) - Math.Sqrt(delta))/(2 * a);
            Console.WriteLine("R1 = {0}",x1.ToString("F5"));
            Console.WriteLine("R2 = {0}",x2.ToString("F5"));
        }

        
    }
}