using System;

public class Ex9
{

    public static void rodar(){
    int[,] matriz=new int[10,10];
        matrizAleatoria(matriz);
        matrizTransposta(matriz);

    }
    public static void matrizAleatoria(int[,] matriz){
        Random r= new Random();
        // Preencher matriz
        for (int i = 0; i < matriz.GetLength(0); i++) {
            for (int j = 0; j < matriz.GetLength(1); j++) {
                matriz[i,j] = r.Next(1,31);  
            }
        }
        // Imprimir matriz
        Console.WriteLine("Matriz:");
        for (int i = 0; i < matriz.GetLength(0); i++) {
            for (int j = 0; j < matriz.GetLength(1); j++) {
                Console.Write($"{matriz[i,j],3} ");
            }
            Console.WriteLine();
        }
    }


    public static void matrizTransposta(int[,] matriz){
    // Cria nova matriz com dimensões invertidas
    int[,] matrizTransposta = new int[matriz.GetLength(1), matriz.GetLength(0)];

    // Preencher matriz transposta
    for (int i = 0; i < matriz.GetLength(0); i++) {
        for (int j = 0; j < matriz.GetLength(1); j++) {
            matrizTransposta[j,i] = matriz[i,j];  
        }
    }

    // Imprimir matriz transposta
    Console.WriteLine("\n\nMatriz transposta:");
    for (int i = 0; i < matrizTransposta.GetLength(0); i++) {
        for (int j = 0; j < matrizTransposta.GetLength(1); j++) {
            Console.Write($"{matrizTransposta[i,j],3} ");
        }
        Console.Write("\n");
        }
    }
}