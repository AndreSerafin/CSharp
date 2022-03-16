using System;
/*Dois carros (X e Y) partem em uma mesma direção. O carro X sai com velocidade 
constante de 60 Km/h e o carro Y sai com velocidade constante de 90 Km/h.
Em uma hora (60 minutos) o carro Y consegue se distanciar 30 quilômetros do
carro X, ou seja, consegue se afastar um quilômetro a cada 2 minutos.
Leia a distância (em Km) e calcule quanto tempo leva (em minutos) para o
carro Y tomar essa distância do outro carro.*/
class uri1016
{

    private static void Main()
    {

        int km,tempo;
        
        km = int.Parse(Console.ReadLine());

        tempo = km*2;

        Console.WriteLine("{0} minutos",tempo);
                

    }
}