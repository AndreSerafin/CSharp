using System; 

/*A fórmula para calcular a área de uma circunferência é: area = π . raio2. Considerando para este problema que π = 3.14159:
Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.*/
class uri1002 {

    private static void Main(string[] args) { 
        
        double A,R,pi;

        pi = 3.14159;
        R = Convert.ToDouble(Console.ReadLine());
        A = pi * Math.Pow(R,2);
        
        Console.WriteLine("A={0}",A.ToString("F4")); 

    }

}