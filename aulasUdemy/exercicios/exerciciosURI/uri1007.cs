using System; 
/*Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo 
produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).*/
class uri1007 {

    private static void Main(string[] args) { 
        
        int A,B,C,D,DIF;

        A = int.Parse(Console.ReadLine());
        B = int.Parse(Console.ReadLine());
        C = int.Parse(Console.ReadLine());
        D = int.Parse(Console.ReadLine());

        DIF = (A * B)-(C * D);

        Console.WriteLine("DIFERENCA = {0}",DIF);
        
    }

}