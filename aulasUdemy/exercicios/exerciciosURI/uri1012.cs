using System;
/*Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. 
Em seguida, calcule e mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.*/
class uri1012{

    private static void Main(){

        double a,b,c,areaTri,areaCirc,areaTrap,areaQuad,AreaRet,pi = 3.14159;
        string[] dados;

        dados = Console.ReadLine().Split(' ');

        a = double.Parse(dados[0]);
        b = double.Parse(dados[1]);
        c = double.Parse(dados[2]);

        areaTri = (a * c) / 2;
        areaCirc = pi * Math.Pow(c,2);
        areaTrap = (a + b) * c / 2;
        areaQuad = b * b;
        AreaRet = a * b;

        Console.WriteLine("TRIANGULO: {0}",areaTri.ToString("F3"));
        Console.WriteLine("CIRCULO: {0}",areaCirc.ToString("F3"));
        Console.WriteLine("TRAPEZIO: {0}",areaTrap.ToString("F3"));
        Console.WriteLine("QUADRADO: {0}",areaQuad.ToString("F3"));
        Console.WriteLine("RETANGULO: {0}",AreaRet.ToString("F3"));

    }

}