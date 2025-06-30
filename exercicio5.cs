using System;
using System.IO;

public class Ex5{

    public static void rodar(){
        //declarando variaveis
        int linhas=0;
        string texto="";
        //chamando função para preencher o texto com o texto do txt e preencher a quantidade de linhas.
        texto=leituraTxt(ref linhas);
        Console.WriteLine($"Arquivo.txt:\n{texto}\nEsse arquivo txt tem {linhas} linhas");
    }
    
    //função que lê o txt e conta as linhas(aproveitar o while de um pro outro já né kk, a e eu não vou explicar denovo linha por linha só fiz isso na primeira até pra eu ter onde ver dps também.)
    public static string leituraTxt(ref int contadorLinhas){
    string texto = "";
    
    StreamReader sr = new StreamReader("a.txt");
    
    string line = sr.ReadLine();
    while (line != null){
        
    texto +=line+"\n";
    //conta as linhas
    contadorLinhas++;
    line = sr.ReadLine();
    }
    
    sr.Close();
    
    return texto;
    }
        
}