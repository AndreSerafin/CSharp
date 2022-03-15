using System;
using System.Globalization;
/*Fazer um programa para ler o nome (apenas uma palavra) e idade de duas pessoas.
Ao final mostrar uma mensagem com os nomes e a idade média entre essas pessoas,
com uma casa decimal, conforme exemplo.*/
class ex05{
    private static void Main(){

        string[] dados1,dados2;
        string nome1,nome2;
        int idade1,idade2;
        double media;

        dados1 = Console.ReadLine().Split(' ');
        dados2 = Console.ReadLine().Split(' ');

        nome1 = dados1[0];
        nome2 = dados2[0];
        idade1 = int.Parse(dados1[1], CultureInfo.InvariantCulture);
        idade2 = int.Parse(dados2[1], CultureInfo.InvariantCulture);

        media = (idade1 + idade2) / 2.0;

        Console.WriteLine("A idade média de {0} e {1} é de {2} anos",nome1,nome2,media.ToString("F1", CultureInfo.InvariantCulture));

    }
}