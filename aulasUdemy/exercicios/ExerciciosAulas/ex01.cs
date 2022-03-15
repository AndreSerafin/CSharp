using System;
using System.Globalization;
class ex01{
    static void Main(){
        
        string nome,uNome;
        int quartos,idade;
        double preco,altura;
        string[] vet;
        
        Console.Write("Digite seu nome completo: ");
        nome = Console.ReadLine();
        Console.Write("Quantos quartos tem sua casa? ");
        quartos = int.Parse(Console.ReadLine());
        Console.Write("Digite o preço de um produto: ");
        preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        Console.Write("Digite seu ultimo nome, idade e altura (Mesma Linha): ");

        vet = Console.ReadLine().Split(' ');
        uNome = vet[0];
        idade = int.Parse(vet[1]);
        altura = double.Parse(vet[2]);

        Console.WriteLine("Nome: {0}\nQuartos: {1}\nPreço: {2}",nome,quartos,preco.ToString("F2",CultureInfo.InvariantCulture));
        Console.WriteLine("Ultimo nome: {0}\nIdade: {1}\nAltura: {2}",uNome,idade,altura.ToString("F2",CultureInfo.InvariantCulture));

    }
}