using System;

public class Ex1{

    public static void Rodar(){
        double num1= 0.0,resultado= 0.0;
        int num2= 0;

        Console.WriteLine("\nÓ Pótencia\n\n");

        Console.Write("Escreva o número da base: ");
        num1=double.Parse(Console.ReadLine());
        resultado=num1;

        Console.Write("Escreva o número do expoente(apenas inteiros): ");
        num2=int.Parse(Console.ReadLine());
        
      
        for( int i=1; i<num2 ; i++ ){
            resultado=resultado*num1;
            }
    Console.WriteLine($"\n\nResultado: {resultado}");
}
}