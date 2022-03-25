using System;

class calcTempo{
    static void Main(){
        
        int anos1=0,meses1=0,dias1=0,anos2=0,meses2=0,dias2=0;
        int qtdd;
        string[] dados;

        Console.Write("Digite a quantidade de calculos: ");
        qtdd = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o tempo em anos : meses : dias: ");

        for(int i = 0;i < qtdd;i++){
        
            dados = Console.ReadLine().Split(' ');

            anos1 = int.Parse(dados[0]);
            meses1 = int.Parse(dados[1]);
            dias1 = int.Parse(dados[2]);

            anos2 += anos1;
            meses2 += meses1;
            dias2 += dias1;

        }
        while(a == true){
        
           if(dias2 > 30){
            dias2 -= 30;
            meses2 += 1;
            }
            if(meses2 > 12){
                meses2 -= 12;
                anos2 += 1;
            }
            if(dias2 <= 30 && meses2 <= 12){
                break;
            }

        }

        
        

        Console.WriteLine("{0} anos, {1} meses, {2} dias",anos2,meses2,dias2);

    }
}