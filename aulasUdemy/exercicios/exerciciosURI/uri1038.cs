using System;

/*Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. 
A seguir, calcule e mostre o valor da conta a pagar.*/

class uri1038{
    private static void Main(){
    
    string[] dados;
    int cod,qtdd;
    double preco=0;

    dados = Console.ReadLine().Split(' ');
    cod = int.Parse(dados[0]);
    qtdd = int.Parse(dados[1]);

    if(cod == 1){
        preco = qtdd * 4.0; 
    }else if(cod == 2){
        preco = qtdd * 4.5;
    }else if(cod == 3){
        preco = qtdd * 5.0;
    }else if(cod == 4){
        preco = qtdd * 2.0;
    }else if(cod == 5){
        preco = qtdd * 1.5;
    }else{
        Console.WriteLine("Codigo invalido");
    }

    Console.WriteLine("Total: R$ {0}",preco.ToString("F2"));
    
    }
}