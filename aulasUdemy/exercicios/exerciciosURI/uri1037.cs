using System;

/*Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes 
intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em 
nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

O símbolo ( representa "maior que". Por exemplo:
[0,25]  indica valores entre 0 e 25.0000, inclusive eles.
(25,50] indica valores maiores que 25 Ex: 25.00001 até o valor 50.0000000*/

class uri1037{
    private static void Main(){
        double n1;

        n1 = double.Parse(Console.ReadLine());

        if(n1 >= 0 && n1 <= 25){
            Console.WriteLine("Intervalo [0,25]");
        }else if(n1 > 25 && n1 <= 50){
            Console.WriteLine("Intervalo (25,50]");
        }else if(n1 > 50 && n1 <= 75){
            Console.WriteLine("Intervalo (50,75]");
        }else if(n1 > 75 && n1 <= 100){
            Console.WriteLine("Intervalo (75,100]");
        }else{
            Console.WriteLine("Fora de intervalo");
        }
    }
}