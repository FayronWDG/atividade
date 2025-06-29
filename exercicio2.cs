using System;

public class Ex2{

    public static void rodar(){
        string frase = "";
        
        //titulo
        Console.WriteLine("\nContador de letras iguais a inicial.\n");

        //pede e guarda a frase
        Console.WriteLine("Escreva uma frase abaixo.");
        frase = Console.ReadLine();

        //mostra a frase sem os espaços
        Console.WriteLine("Frase sem espaço abaixo.\n"+conversorFraseSemEspaço(frase));
    
    }

    //conversor de frase para tirar os espaços.
    public static string conversorFraseSemEspaço(string frase){
        string resultado= "";
        string[] palavras = frase.Split(' ');

       
        
        for (int i = 0; i < palavras.Length; i++)
        {
            if (palavras[i]!="") {
                resultado += palavras[i];
            }
        }
        return resultado;
    }
}

