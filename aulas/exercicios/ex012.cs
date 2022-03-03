using System;
/*Write a C# program to that takes a number as input and display it four times in a row 
(separated by blank spaces), and then four times in the next row, with no separation. 
You should do it two times: Use Console. Write and then use {0}.*/
class ex012{
    static void Main(){
        
        string n1;
        Console.Write("Digite um numero inteiro! ");
        n1 = Console.ReadLine();

        Console.WriteLine(n1+" "+n1+" "+n1+" "+n1);
        Console.WriteLine(n1+n1+n1+n1);

        Console.WriteLine("{0} {1} {2} {3}",n1,n1,n1,n1);
        Console.WriteLine("{0}{1}{2}{3}",n1,n1,n1,n1);
    }
}