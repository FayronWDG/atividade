using System;
using System.IO;
using System.Text;

public class Ex7{

     public static void rodar(){
        //declarando variavel
        int quantidade = 0,vogais = 0;
        string letras = "";
        
        //titulo
        Console.WriteLine("contador de vogais de um arquivo");
       
        Console.Write("Escreva o número de letras a ser inserido no arquivo: ");
        gravarTxt(letras,int.Parse(Console.ReadLine()));
        Console.WriteLine("\nLetras gravadas com sucesso no txt.");
        vogais = ContarVogais();
        Console.WriteLine($"\nE nesse txt tem {vogais} vogais.");
    
    }   
    
    public static int ContarVogais(){
        StreamReader sr = new StreamReader("registro.txt");
        int vogais = 0;
        string line = sr.ReadLine();
        
        for(int i=0;line.Length> i; i++)
        {
            if(line[i] == 'a' || line[i] == 'e' || line[i] == 'i' || line[i] == 'o' || line[i] == 'u'){
                vogais++;
            }
        }

        sr.Close();
        return vogais;
    }    
   
    //função para pedir as letras e para gravar elas no txt.
    public static void gravarTxt(string letras,int quantidade){

        StreamWriter sw = new StreamWriter("registro.txt");
        for(int i = 0; i < quantidade;i++){

            Console.Write($"Escreva a letra número {i+1}: ");
            letras +=char.Parse(Console.ReadLine());
            sw.Write(letras[i]+" ");

        }
        sw.Close();

    }
   

   
}
