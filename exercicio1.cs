using System;

//nome:Wallyson Soares Vieira
//vou fazer 2 tipos: um que pega a primeira letra do meu nome(W) e outro que considera a primeira letra da frase, em ambos vou considerar tanto maiuscula quanto minuscula(vou dar um ToLowerCase)
//foi mal se isso não ser o que você quer, mas além do enunciado ter me deixado com duvida eu gostei da ideia de fazer assim.

public class Ex1{



    public static void rodar(){
        //variaveis sendo declaradas
        string frase = "" ;
        char letra = ' ' ;
        int contador = 0;

        //titulo('-' sim eu fiz fora de ordem)
        Console.WriteLine("\nContador de letras iguais a inicial.\n");

        //pede e guarda a frase
        Console.WriteLine("Escreva uma frase abaixo.");
        frase = Console.ReadLine();
        
        //escolhe o tipo de letraa ser guardado no contador.
        Console.WriteLine("Escreva 1 para usar a primeira letra da frase que você escreveu\nEscreva 2 para usar a primeira letra do meu nome(W).");
        switch(int.Parse(Console.ReadLine())){
            
            case 1:
            letra = frase[0];
            contador = quantidadeDeLetras(frase,letra);
            break;
            
            case 2:
            letra = 'W';
            contador = quantidadeDeLetras(frase,letra);
            break;   
        }

        //mostra o resultado na tela do usuario.
        Console.WriteLine($"A quantidade de {letra} é: {contador}");

    }
    
    //função que recebe a frase e a letra e retorna a quantidade de vezes que essa letra se repete na frase.
    public static int quantidadeDeLetras(string frase, char letra){
        int contador=0;
        letra= char.ToUpper(letra);
        for (int i = 0; i < frase.Length; i++)
        {
            if (char.ToUpper(frase[i]) == letra) {
               contador++;
            }
        }
        return contador;
    }
}