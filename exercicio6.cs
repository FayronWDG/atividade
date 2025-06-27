using System;

public class Ex6{

    public static void rodar(){
        double[] temp=new double[31];
        
        
        vetorTemp(temp);
        mediaContador(temp);


    }        

    
    public static void vetorTemp(double[] temp){
        
        //criando objeto para Random(para pegar números aleatorios)
        Random r= new Random();

        Console.Write("Temperaturas Outubro: ");
        for(int i=0;i<temp.Length;i++){
            //usando valores aleatorios para preenchero vetor de 15 indices e mostrando os valores do vetor no terminal
            temp[i]=r.Next(150,400)/10.0;
            Console.Write($"{temp[i]}°C ");
        }
    }


    //procedimento que calcula a media e a quantidade de temperatura abaixo da média e a maior e a menor temperatura e mostra no terminal.
    public static void mediaContador(double[] temp){
        double somaTemp=0, mediaTemp=0, maior=double.MinValue , menor=double.MaxValue;
        int abaixoMedia=0;

        Console.Write("\n");
        for(int i=0;i<temp.Length;i++){
            somaTemp+=temp[i];
        }
        mediaTemp=somaTemp/temp.Length;

        for(int i=0;i<temp.Length;i++){
            if(temp[i]<mediaTemp){
                abaixoMedia++;
            }
            if(menor>temp[i]){
                menor=temp[i];
            }
            if(maior<temp[i]){
                maior=temp[i];
            }
        }
        //mostrando tudo no terminal
        Console.WriteLine($"\nA media da temperatura de outubro foi: {mediaTemp:F2}\nE os dias que tiveram temperatura abaixo da media somaram: {abaixoMedia} dias.\nA menor temperatura foi: {menor}\nA maior temperatura foi: {maior}.\n");

    }
}
