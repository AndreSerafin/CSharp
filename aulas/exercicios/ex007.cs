using System;
/*Write a C# Sharp program to print on screen the output of adding, subtracting, 
multiplying and dividing of two numbers which will be entered by the user.*/

class ex007{
    static void Main(){
        
        int n1,n2,soma,sub,mult,div,rest;
        
        Console.Write("Digite dois numeros inteiros: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());
        
        soma = n1 + n2;
        sub = n1 - n2;
        mult = n1 * n2;
        div = n1 / n2;
        rest = n1 % n2;

        Console.WriteLine("A soma de {0} mais {1} é:\t\t {2}",n1,n2,soma);
        Console.WriteLine("A subtraçao de {0} menos {1} é:\t {2}",n1,n2,sub);
        Console.WriteLine("A multiplicação de {0} e {1} é:\t {2}",n1,n2,mult);
        Console.WriteLine("A divisão de {0} e {1} é:\t\t {2}",n1,n2,div);
        Console.WriteLine("O resto da divisão de {0} e {1} é:\t {2}",n1,n2,rest);
    }
}