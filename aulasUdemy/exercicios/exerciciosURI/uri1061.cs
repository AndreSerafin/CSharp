using System;
/*Como entrada, na primeira linha vai haver a descrição “d”, suido de um espaço e o d do mês no qual 
o evento vai começar. Na linha suinte, será informado o momento no qual o evento vai iniciar, no formato 
hh : mm : ss. Na terceira e quarta linha de entrada haverá outra informação no mesmo formato das duas primeiras 
linhas, indicando o térmo do evento.*/
class uri1061{
    private static void Main(){

        int dInic,hInic,mInic,sInic,dFinal,hFinal,mFinal,sFinal;
        int W,X,Y,Z;
        string[] dadosInic,dadosFinal;

        dInic = Convert.ToInt32(Console.ReadLine());
        dadosInic = Console.ReadLine().Replace(" ","").Split(':');
        dFinal = Convert.ToInt32(Console.ReadLine());
        dadosFinal = Console.ReadLine().Replace(" ","").Split(':');

        hInic = Convert.ToInt32(dadosInic[0]);
        mInic = Convert.ToInt32(dadosInic[1]);
        sInic = Convert.ToInt32(dadosInic[2]);
        hFinal = Convert.ToInt32(dadosFinal[0]);
        mFinal = Convert.ToInt32(dadosFinal[1]);
        sFinal = Convert.ToInt32(dadosFinal[2]);

        W = dFinal - dInic;
        X = hFinal - hInic;
        Y = mFinal - mInic;
        Z = sFinal - sInic;
        

        if(Z < 0){
            
            Z += 60;
            Y --; 

        }
        if(Y < 0){
            
            Y += 60;
            X --;

        }
        if(X < 0){

            X += 24;
            W --;

        }

        Console.WriteLine("{0} dia(s)",W);
        Console.WriteLine("{0} hora(s)",X);
        Console.WriteLine("{0} minutos(s)",Y);
        Console.WriteLine("{0} segundo(s)",Z);

    }
}