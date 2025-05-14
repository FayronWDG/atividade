using System;

public class Ex5{

    public static void Rodar(){
        int n=0, numero=0;
        Console.WriteLine("\nNegativo ou Positivo.\n");
  
        Console.Write("Escreva a quantidade de números a ser testada: ");
        n=int.Parse(Console.ReadLine());
        for(int i=0 ; i < n ;i++ ){
            Console.WriteLine($"\n{i+1}º número\n");
            Console.Write("Escreva um número inteiro: ");
            numero=int.Parse(Console.ReadLine());
            switch(PouN(numero)){
                case true :
                Console.WriteLine($"\nO {numero} é um número positivo");
                break;
                case false :
                Console.WriteLine($"\nO {numero} é um número negativo");
                break;
            }
        }
    }
    public static bool PouN(int num){
        bool resultado;
        if(num>=0){
            resultado=true;
        }
        else{
            resultado=false;
        }
        return resultado;
    }
}
