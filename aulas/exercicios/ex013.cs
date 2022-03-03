using System;
//Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
class ex013{
    static void Main(){
        
        double celc,far,kelv;

        Console.Write("Digite uma temperatura em °C: ");
        celc = Convert.ToDouble(Console.ReadLine());

        kelv = celc + 273.15;
        far = celc * 1.8 + 32;

        Console.WriteLine("{0}°C em °F é: {1}°F",celc,far);
        Console.WriteLine("{0}°C em K é: {1}K",celc,kelv);
        
    }
}