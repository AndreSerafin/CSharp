using System;
//Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.
class ex016{
    static void Main(){
        
        string frase;

        Console.WriteLine("Digite uma frase: ");
        frase = Console.ReadLine();

        if(frase.Length>=1){
            var s = frase.Substring(0,1);
            Console.WriteLine(s + frase +s);
            var s2 = frase[frase.Length - 1];
            Console.WriteLine(s2 + frase + s2);
        }

    }
}