using System;
//Write a C# program to create a new string from a given string where the first and last characters will change their positions.
class ex015{
    
    static void Main(){
        
        string s;
        
        
        Console.Write("Digite uma palavra: ");
        s = Console.ReadLine();
        s = s.Substring(s.Length - 1) + s.Substring(s.StartsWith) + s.Substring(0,1);
        Console.Write("Primeira e ultima letras trocadas: "+s);
    }

}