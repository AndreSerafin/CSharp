using System;

class ex05{
    private static void Main(){
        double nota1,nota2,media;

        Console.WriteLine("Digite a primeira nota do aluno: ");
        nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a segunda nota do aluno: ");
        nota2 = double.Parse(Console.ReadLine());

        media = nota1 + nota2;

        if(media >= 60){
            Console.WriteLine("NOTA FINAL = {0}",media.ToString("F2"));
        }else{
            Console.WriteLine("NOTA FINAL = {0}\nREPROVADO",media.ToString("F2"));
        }

    }
}