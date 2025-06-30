using System;
//biblioteca usada para ler o txt
using System.IO;

public class Ex3{

    public static void rodar(){

        //titulo
        Console.WriteLine("Leitura de txt:\n");
        //lê  e mostra na tela do usuario tudo que tem no txt com as linhas separadas como no txt
        Console.WriteLine("no arquivo tem "+ contadorPalavras(leituraTxt())+" palavras.");


    }

    //função que lê o txt e retorna uma string
    public static string leituraTxt(){
        //variavel sendo declarada para guardar o  texto.
        string texto = "";
        //abre o arquivo
        StreamReader sr = new StreamReader("a.txt");
        //variavel para receber a leitura da linha do txt
        string line = sr.ReadLine();
        while (line != null){
            //variavel para guarar o texto igualmente como esta no txt.
            texto +=line+"\n";
            //proxima linha para ser lida
            line = sr.ReadLine();
        }
        //fecha o arquivo.
        sr.Close();
        //retorna o texto que tem no txt como string
        return texto;
    }

    
    //conta quantas palavras tem em uma string
    public static int contadorPalavras(string frase){
        string[] palavras = frase.Split(' ',',',';','\n');
        int contador = 0;

        for (int i = 0; i < palavras.Length; i++)
        {       
            if(palavras[i] != ""){
                contador++;
            }
        }
        return contador; 
    }  
}
