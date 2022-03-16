using System; 
/*Leia dois valores inteiros, no caso para variáveis A e B. A seguir, 
calcule a soma entre elas e atribua à variável SOMA. A seguir escrever o valor desta variável.*/
class uri1003 {

    private static void Main(string[] args) { 
        
        int A,B,SOMA;
        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());

        SOMA = A+B;

        Console.WriteLine("SOMA = {0}",SOMA);
    }

}