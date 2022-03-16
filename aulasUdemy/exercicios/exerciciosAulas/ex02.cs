using System;
using System.Globalization;
class ex02
{

    static void Main(){
        double larg, comp, valor,area,preco;
        string[] s;

        Console.Write("Digite o valor da largura, comprimento e o valor(Na mesma linha separado por espaço): ");
        s = Console.ReadLine().Split(' ');

        larg = Convert.ToDouble(s[0], CultureInfo.InvariantCulture);
        comp = Convert.ToDouble(s[1], CultureInfo.InvariantCulture);
        valor = Convert.ToDouble(s[2], CultureInfo.InvariantCulture);

        area = larg * comp;
        preco = area * valor;

        Console.WriteLine("O terreno de {0} x {1} tem uma area de: {2}",larg.ToString("F2",CultureInfo.InvariantCulture),comp.ToString("F2",CultureInfo.InvariantCulture),area.ToString("F2",CultureInfo.InvariantCulture));
        Console.WriteLine("O valor do m² é {0} portanto o preço final do terreno é: {1}",valor.ToString("F2",CultureInfo.InvariantCulture),preco.ToString("F2",CultureInfo.InvariantCulture));

    }
}