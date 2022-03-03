using System;
//Write a C# program remove specified a character from a non-empty string using index of a character.
class ex014{
    static void Main(){
        
        string s;
        int r;

        for(int i=0;i<=3;i++){
        Console.Write("Digite uma palavra: ");
        s = Console.ReadLine();
        Console.Write("Digite a posição do caractere a ser removido: ");
        r = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(removeChar(s,r));
        }
    }

    static string removeChar(string str, int n){
        
        return str.Remove(n,1);

    }
}