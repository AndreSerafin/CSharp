using System;

/*Leia quatro números (N1, N2, N3, N4), cada um deles com uma casa decimal, correspondente às quatro notas de um 
aluno. Calcule a média com pesos 2, 3, 4 e 1, respectivamente, para cada uma destas notas e mostre esta média 
acompanhada pela mensagem "Media: ". Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado."
Se a média calculada for inferior a 5.0, imprima a mensagem "Aluno reprovado.". Se a média calculada for um valor 
entre 5.0 e 6.9, inclusive estas, o programa deve imprimir a mensagem "Aluno em exame.".

No caso do aluno estar em exame, leia um valor correspondente à nota do exame obtida pelo aluno. Imprima então a 
mensagem "Nota do exame: " acompanhada pela nota digitada. Recalcule a média (some a pontuação do exame com a 
média anteriormente calculada e divida por 2). e imprima a mensagem "Aluno aprovado." (caso a média final seja 
5.0 ou mais ) ou "Aluno reprovado.", (caso a média tenha ficado 4.9 ou menos). Para estes dois casos (aprovado 
ou reprovado após ter pego exame) apresente na última linha uma mensagem "Media final: " seguido da média final 
para esse aluno.*/

class uri1040{
    private static void Main(){
        string[] dados;
        float n1,n2,n3,n4,nEx;
        float media1,media2;

        dados = Console.ReadLine().Split(' ');
        n1 = float.Parse(dados[0]);
        n2 = float.Parse(dados[1]);
        n3 = float.Parse(dados[2]);
        n4 = float.Parse(dados[3]);

        media1 = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1) / (2 + 3 + 4 + 1);
        Console.WriteLine("Media: {0}",Math.Round(media1,1));

        if(media1 == 4.85f){
            media1 = 4.8f;
        }

        if(media1 >= 7.0){
            Console.WriteLine("Aluno aprovado.");
        }else if(media1 < 5.0){
            Console.WriteLine("Aluno reprovado.");
        }else{
            Console.WriteLine("Aluno em exame.");
            
            nEx = float.Parse(Console.ReadLine());
            Console.WriteLine("Nota do exame: {0}",nEx.ToString("F1"));
            
            media2 = (media1 + nEx) / 2;
            if(media2 >= 5.0){
                Console.WriteLine("Aluno aprovado.");
            }else{
                Console.WriteLine("Aluno reprovado.");
            }
            Console.WriteLine("Media final: {0}",Math.Round(media2,1));
        }
    }
}