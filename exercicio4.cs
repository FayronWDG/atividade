using System;


public class Ex4
{

    public static void rodar()
    {
        //declarando variavel
        string frase;

        //titulo sobre o que o  codigo faz.
        Console.WriteLine("\nCódigo de César\n");
        //pedindo frase e guardando a ser codificada.
        Console.WriteLine("Escreva uma frase para ser codificado no Código de César (3 posições cada letra).");
        frase = Console.ReadLine();
        //chamando codificador e escrevendo a frase codificada para o usuario;
        Console.WriteLine("Coificada: "+ConversorFraseCesar(frase));
    }

    //função que muda o caracter para 3 caracteres na tabela ASCII para frente e retorna ele.
    public static char CodigoCesar(char letra) {
        letra=(char)(letra + 3);
        return letra;
    }
    //função que codifica a frase caracter por caracter pulando os espaços e retornando a frase codificada.
    public static string ConversorFraseCesar(string frase){
        char[] convertida=new char[frase.Length];
        string fraseConvertida;
        for (int i = 0; i < frase.Length; i++)
        {
            if (frase[i]==' ') {
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
