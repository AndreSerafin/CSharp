using System; 
/*Leia dois valores inteiros, no caso para variáveis A e B. A seguir, 
calcule o produto entre elas e atribua à variável PROD. A seguir escrever o valor desta variável.*/
class uri1004 {

    private static void Main(string[] args) { 
        
        int A,B,PROD;
        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());

        PROD = A*B;

        Console.WriteLine("PROD = {0}",PROD);
    }

}