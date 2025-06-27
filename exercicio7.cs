using System;

public class Ex7{

    public static void rodar(){    
        int[,] matriz =new int[3,3];

        matrizAleatoria(matriz);
        
        Console.WriteLine($"soma das posições dos numeros primos da matriz = {matrizPrimo(matriz)}");
    
    
    
    }

    //pega os números primos e soma suas posições dentro da matriz
    public static int matrizPrimo(int[,] matriz){
    
    //declarando variaveis
    int divisores = 0, somaPosições = 0;
    
    
    for (int i = 0; i < matriz.GetLength(0); i++) {
    for (int j = 0; j < matriz.GetLength(1); j++) {
        //reseta os divisores.
        divisores=0;

    //testa os divisores para ver se é primo.
    for (int contador = 1; contador <= matriz[i,j]; contador++) {
        if (matriz[i,j] % contador == 0) {
            divisores++;
        }
    }     

            //testa o numero de divisores para determinar se é primo
            if (divisores == 2) {
              somaPosições = somaPosições + i + j;
            } 
        }
    }
    //retorna a soma das posições de numeros primos.
    return somaPosições;
    }

    public static void matrizAleatoria(int[,] matriz){
        Random r= new Random();  



    // Preencher matriz
    for (int i = 0; i < matriz.GetLength(0); i++) {
        for (int j = 0; j < matriz.GetLength(1); j++) {
            matriz[i,j] = r.Next(1,31);  
        }
    }
    Console.Write("[");
    // Percorrer matriz e imprimir
    for (int i = 0; i < matriz.GetLength(0); i++) {
         if(i!=0){
            Console.Write(" ");
        }
        for (int j = 0; j < matriz.GetLength(1); j++) {
            
            Console.Write($"{matriz[i,j]} ");
                if(j==2 && i!=2){
                Console.Write("\n");
            }
           
        }
        
         if(i==2){
                Console.WriteLine("]");
            }
       
        }
    }
}
