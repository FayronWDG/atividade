using System;

public class Ex3{

    public static void Rodar(){
       triangulo();
    }  
    public static void triangulo(){
        double x=0,y=0,z=0;
        int contadorInf=int.MaxValue;
        for (int i = 0;contadorInf>= i;) {
            Console.WriteLine($"Escreva um valor menor ou igual a 0 para encerrar o programa\nTriangulo {i + 1}\n");

            Console.Write("Escreva o primeiro lado de um triangulo: ");
            x = double.Parse(Console.ReadLine());
            if (x <= 0) {
                break;
            }
            Console.Write("Escreva o segundo lado de um triangulo: ");
            y = double.Parse(Console.ReadLine());
            if (y <= 0) {
                break;
            }
            Console.Write("Escreva o terceiro lado de um triangulo: ");
            z = double.Parse(Console.ReadLine());
            if (z <= 0) {
                break;
            }

            if ((x + y) > z && (x + z) > y && (z + y) > x) {
                tipoTri(x, y, z);
                i++;
            }
            else {
                Console.WriteLine("\nCom esses valores não se forma um triângulo.");
            }
        }
        Console.WriteLine("Fim 3 programa.\n");
    }    
    public static void tipoTri(double x,double y,double z){
        if(x==z && z==y){
            Console.WriteLine("\nSão os lados de um triângulo equilátero(três lados iguais).");
        }
        else if( x==z || z==y || x==y ){
            Console.WriteLine("\nSão os lados de um triângulo isocéles(dois lados iguais).");
        }
        else {
        Console.WriteLine("\nSão os lados de um triângulo escaleno(todos os lados diferentes)");
        }
        Console.WriteLine($"\nO primeiro lado: {x}\nO segundo lado: {y}\nO terceiro lado: {z}\n");
    } 
}
