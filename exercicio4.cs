using System;
using System.ComponentModel.Design;

public class Ex4
{

    public static void rodar()
    {
        string frase;
        Console.WriteLine("Escreva algo para ser codificado no Código de César.(3 posições cada letra)");
        frase = Console.ReadLine();
        Console.WriteLine(ConversorFraseCesar(frase));


    }
    public static char CodigoCesar(char letra) {
        char n =(char)(letra + 3);
        return n;
    }
    public static string ConversorFraseCesar(string frase){
        char[] convertida=new char[frase.Length];
        string fraseConvertida;
        for (int i = 0; i < frase.Length; i++)
        {
            if (frase[i].CompareTo(' ') == 0) {
                convertida[i] =' ';
            }else
            {
                convertida[i]=CodigoCesar((char)frase[i]);
            }
        }
        fraseConvertida =new string(convertida);
        return fraseConvertida;
    }
}
