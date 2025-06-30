using System;
using System.IO;
using System.Text;

public class Ex6{

    public static void rodar(){
        //declarando variavel
        int numero = 0, soma = 0;
        
        //titulo
        Console.WriteLine("Soma de divisores de um número inteiro");
        //pede um numero para o usuario, calcula os divisores exatos e mostra na tela do usuario todos os divisores, e depois guarda a soma desses divisores no registro.txt que está dentro da pasta
        Console.Write("Escreva um número inteiro: ");
        numero =int.Parse(Console.ReadLine());
        soma = somaDivisores(numero);
        gravarTxt(numero,soma);
        //mensagem para a pessoa saber que foi guardado no arquivo.
        Console.WriteLine("\nA soma dos divisores foi guardada no registro.txt");
    
    
    }   
    //função para somar e mostrar na tela do usuario os divisores de um número
    public static int somaDivisores(int numero){
        int soma=0;
        Console.WriteLine("Divisores: ");
        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                Console.Write(i+" ");
                soma+=i;
            }
        }

    return soma;
    }    
   
    //função para gravar no arquivo txt a soma do número
    public static void gravarTxt(int numero,int soma){

        StreamWriter sw = new StreamWriter("registro.txt", true, Encoding.ASCII);

        sw.Write($"\nsoma dos divisores de {numero}: {soma}.");
        
        sw.Close();

    }
   
}
