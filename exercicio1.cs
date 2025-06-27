using System;

public class Ex1{

    public static void rodar(){
    //declarando vetor inteiro
    int[] vetor15=new int[15];

    novoVetor(vetor15);
    imprimirVetor(vetorPares(vetor15));
    }
    
    //procedimento que preenche um vetor de 15 indices
    public static void novoVetor(int[] vetor){
        //criando objeto para Random(para pegar números aleatorios)
        Random r= new Random();
        for(int i=0;i<vetor.Length;i++){
            //usando valores aleatorios para preencher o vetor de 15 indices e mostrando os valores do vetor no terminal
            vetor[i]=r.Next(60);
            Console.Write($"{vetor[i]} ");
        }
    }
    //função que retorna um vetor só com os números pares do vetor de parametro
    public static int[] vetorPares(int[] vetor){
        //declarando variaveis
        int[] vetorPar;
        int contador=0;    
        
        //teste para saber se é impar e se for tem que fazer um aumento no tamanho do vetorPar para funcionar
        if(vetor.Length%2!=0){
            vetorPar=new int[(vetor.Length+1)/2];
        }else{
            vetorPar=new int[vetor.Length/2];
        } 
        
            for(int i=0 ; i < vetor.Length ; i=i+2){
                vetorPar[contador]=vetor[i];
                contador++;
            }
            
        return vetorPar;
    }
    //procedimento que imprime o vetor passado por parametro no terminal
    public static void imprimirVetor(int[] imprimir){
        for(int i=0 ; i < imprimir.Length ; i++){
        if(i==0){
            Console.WriteLine("\n");    
        }
        Console.Write($"{imprimir[i]} ");
        }
    }
}