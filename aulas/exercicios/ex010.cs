using System;
 //Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.
 class ex010{
     static void Main(){

         int x,y,z,op1,op2;

         Console.Write("Digite três números: ");
         x = Convert.ToInt32(Console.ReadLine());
         y = Convert.ToInt32(Console.ReadLine());
         z = Convert.ToInt32(Console.ReadLine());
         

         op1 = (x + y) * z;
         op2 = (x * y) + (y * z);

         Console.WriteLine("O resultado de ({0} * {1}) * {2} é: {3}",x,y,z,op1);
         Console.WriteLine("O resultado de {0} * {1} + {2} * {3} é: {4}",x,y,y,z,op2);


     }
 }