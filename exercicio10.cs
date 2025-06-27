using System;

public class Ex10{

    public static void rodar(){
        //cria e preenche matriz 10x10 com valores aleatórios
        int[,] matriz = new int[10,10];
        matrizAleatoria(matriz);

        //troca linha 2 com linha 8 e mostra resultado
        trocaLinha(matriz, 2, 8);

        //troca coluna 4 com coluna 10 e mostra resultado
        trocaColuna(matriz, 4, 10);

        //troca diagonal principal com diagonal secundária e mostra resultado
        trocaDiagonal(matriz);
    }

    //preenche matriz com números aleatórios e imprime
    public static void matrizAleatoria(int[,] matriz){
        Random r = new Random();

        Console.WriteLine("Matriz original:");
        for(int i=0; i<matriz.GetLength(0); i++){
            for(int j=0; j<matriz.GetLength(1); j++){
                matriz[i,j] = r.Next(1,31);
                Console.Write($"{matriz[i,j],3} ");
            }
            Console.WriteLine();
        }
    }

    //troca duas linhas da matriz e imprime o resultado
    public static void trocaLinha(int[,] matriz, int linha1, int linha2){
        linha1 -= 1;
        linha2 -= 1;

        for(int j=0; j<matriz.GetLength(1); j++){
            int aux = matriz[linha1, j];
            matriz[linha1, j] = matriz[linha2, j];
            matriz[linha2, j] = aux;
        }

        Console.WriteLine($"\nMatriz após troca da linha {linha1+1} com linha {linha2+1}:");
        imprimirMatriz(matriz);
    }

    //troca duas colunas da matriz e imprime o resultado
    public static void trocaColuna(int[,] matriz, int coluna1, int coluna2){
        coluna1 -= 1;
        coluna2 -= 1;

        for(int i=0; i<matriz.GetLength(0); i++){
            int aux = matriz[i, coluna1];
            matriz[i, coluna1] = matriz[i, coluna2];
            matriz[i, coluna2] = aux;
        }

        Console.WriteLine($"\nMatriz após troca da coluna {coluna1+1} com coluna {coluna2+1}:");
        imprimirMatriz(matriz);
    }

    //troca diagonal principal com diagonal secundária e imprime o resultado
    public static void trocaDiagonal(int[,] matriz){
        int n = matriz.GetLength(0);

        for(int i=0; i<n; i++){
            int aux = matriz[i, i];
            matriz[i, i] = matriz[i, n - 1 - i];
            matriz[i, n - 1 - i] = aux;
        }

        Console.WriteLine("\nMatriz após troca da diagonal principal com a diagonal secundária:");
        imprimirMatriz(matriz);
    }

    //imprime matriz formatada no console
    public static void imprimirMatriz(int[,] matriz){
        for(int i=0; i<matriz.GetLength(0); i++){
            for(int j=0; j<matriz.GetLength(1); j++){
                Console.Write($"{matriz[i,j],3} ");
            }
            Console.WriteLine();
        }
    }
}