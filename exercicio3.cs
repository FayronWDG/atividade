using System;

public class Ex3{

    public static void rodar(){
   
    
    novoVetor();
    


    }  

    public static void novoVetor(){
        double[] vetor;
        //declarando variavel
        int tamanho=0;
        Random r= new Random();
        //pedindo o tamanho do vetor
        Console.Write("\nEscreva o tamanho do seu vetor: ");
        tamanho=int.Parse(Console.ReadLine());
        
        //declarando tamanho do vetor
        vetor=new double[tamanho];
 
        for(int i=0;i<vetor.Length;i++){
            //usando valores aleatorios para preencher o vetor
            vetor[i]=r.Next(1000)/10.0;
            Console.Write($"{vetor[i]} ");
        }
        Console.WriteLine("\nO menor valor desse vetor é: "+menorVetor(vetor));
    }
    
    //função que pega o menor valor do vetor e volta ele para a chamada.
    public static double menorVetor(double[] vetor){
        double menor=double.MaxValue;
        //repetição para achar o menor do vetor
        for(int i=0;i<vetor.Length;i++){
            if(menor>vetor[i]){
                menor=vetor[i];
            }
        }

        //retornando o menor.
        return menor;
    }
}
