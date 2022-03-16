using System;
/*Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. A seguir, calcule a média do 
aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5. Considere que cada nota pode 
ir de 0 até 10.0, sempre com uma casa decimal.*/
class uri1006{
    private static void Main(){

        double nota1,nota2,nota3,media;

        nota1 = double.Parse(Console.ReadLine());
        nota2 = double.Parse(Console.ReadLine());
        nota3 = double.Parse(Console.ReadLine());

        media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / 10.0;

        Console.WriteLine("MEDIA = {0}",media.ToString("F1"));

    }
}