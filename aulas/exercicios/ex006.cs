using System;
//Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
/*Test Data:
Input the first number to multiply: 2
Input the second number to multiply: 3
Input the third number to multiply: 6*/
class ex006{
    static void Main(){
        int n1,n2,n3,mult;

        Console.WriteLine("Digite tres numeros inteiros: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        n2 = Convert.ToInt32(Console.ReadLine());
        n3 = Convert.ToInt32(Console.ReadLine());

        mult=n1*n2*n3;
        Console.Write("A mutiplicaçao {0} * {1} * {2} é igual: {3}",n1,n2,n3,mult);

    }
}