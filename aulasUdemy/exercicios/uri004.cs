using System; 

/*Leia 2 valores de ponto flutuante de dupla precisão A e B, que correspondem a 2 notas de um aluno. 
A seguir, calcule a média do aluno, sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11).
Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.*/
class uri004 {

    static void Main(string[] args) { 
        
        double A,B,C,M;

        A = double.Parse(Console.ReadLine());
        B = double.Parse(Console.ReadLine());
        C = double.Parse(Console.ReadLine());

        M = ((A * 2) + (B * 3) + (C * 5)) / 10;

        Console.WriteLine("MEDIA = {0}",M.ToString("F1"));
        
    }

}