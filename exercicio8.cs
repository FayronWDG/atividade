using System;

public class Ex8{

    public static void rodar(){
        int[,] matriz= new int[5,5];
        
        matrizAleatoria(matriz);
        imprimirAcoesMatriz(matriz);
        
    }   

    //imprime todas as somas calculadas da matriz
    public static void imprimirAcoesMatriz(int[,] matriz){
        //corrigido o Console.WriteLine para não quebrar string no meio
        Console.WriteLine($"\nSoma da linha 3: {SomaLinha(matriz, 3)}");
        Console.WriteLine($"Soma da coluna 2: {SomaColuna(matriz, 2)}");
        Console.WriteLine($"Soma da diagonal principal: {SomaDiagonalPrincipal(matriz)}");
        Console.WriteLine($"Soma da diagonal secundária: {SomaDiagonalSecundaria(matriz)}");
        Console.WriteLine($"Soma de todos os elementos: {SomaTodosElementos(matriz)}");
    }

    //preenche matriz com números aleatórios e imprime
    public static void matrizAleatoria(int[,] matriz){
        Random r= new Random();  

        for (int i = 0; i < matriz.GetLength(0); i++) {
            for (int j = 0; j < matriz.GetLength(1); j++) {
                matriz[i,j] = r.Next(1,31);  
            }
        }

        Console.WriteLine("Matriz:");
        for (int i = 0; i < matriz.GetLength(0); i++) {
            for (int j = 0; j < matriz.GetLength(1); j++) {
                Console.Write($"{matriz[i,j],3} ");
            }
            Console.WriteLine();
        }
    }

    //soma os elementos da linha especificada
    public static int SomaLinha(int[,] matriz, int linha){
        int soma = 0;
        for(int j=0; j < matriz.GetLength(1); j++){
            soma += matriz[linha,j];
        }
        return soma;
    }

    //soma os elementos da coluna especificada
    public static int SomaColuna(int[,] matriz, int coluna){
        int soma = 0;
        for(int i=0; i < matriz.GetLength(0); i++){
            soma += matriz[i,coluna];
        }
        return soma;
    }

    //soma os elementos da diagonal principal
    public static int SomaDiagonalPrincipal(int[,] matriz){
        int soma = 0;
        int n = matriz.GetLength(0);
        for(int i=0; i < n; i++){
            soma += matriz[i,i];
        }
        return soma;
    }

    //soma os elementos da diagonal secundária
    public static int SomaDiagonalSecundaria(int[,] matriz){
        int soma = 0;
        int n = matriz.GetLength(0);
        for(int i=0; i < n; i++){
            soma += matriz[i,n - 1 - i];
        }
        return soma;
    }

    //soma todos os elementos da matriz
    public static int SomaTodosElementos(int[,] matriz){
        int soma = 0;
        for(int i=0; i < matriz.GetLength(0); i++){
            for(int j=0; j < matriz.GetLength(1); j++){
                soma += matriz[i,j];
            }
        }
        return soma;
    }
}