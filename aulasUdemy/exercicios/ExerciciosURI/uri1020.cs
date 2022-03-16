using System;
/*Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias
Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos de 
teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. Este é apenas um 
exercício com objetivo de testar raciocínio matemático simples.*/
class uri1020
{

    private static void Main(){

        int dia,mes,ano;

        dia = int.Parse(Console.ReadLine());
        
        ano = dia/365;
        dia %= 365;
            
        mes = dia/30;
        dia %= 30;

        Console.WriteLine("{0} ano(s)",ano);
        Console.WriteLine("{0} mes(es)",mes);   
        Console.WriteLine("{0} dia(s)",dia);
        
    }
    
}