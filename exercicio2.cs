using System;

public class Ex2{

    public static void rodar(){
        //declarando variavel vetor
        double[] turmaNotas=new double[10];

        //chamando metodos para colocar números no vetor e calcular a média e a quantidade de alunos acima da média e mostra para o usuario
        vetorTurma(turmaNotas);
        mediaContador(turmaNotas);

    }      


    public static void vetorTurma(double[] turma){
        
        //criando objeto para Random(para pegar números aleatorios)
        Random r= new Random();

        Console.Write("Notas da turma: ");
        for(int i=0;i<turma.Length;i++){
            //usando valores aleatorios para preenchero vetor de 15 indices e mostrando os valores do vetor no terminal
            turma[i]=r.Next(100)/10.0;
            Console.Write($"{turma[i]} ");
        }
    }


    //procedimento que calcula a media e a quantidade de alunos acima da média e mostra no terminal.
    public static void mediaContador(double[] turma){
        double somaNotas=0,mediaNotas=0;
        int acimaMedia=0;

        for(int i=0;i<turma.Length;i++){
            somaNotas+=turma[i];
        }
        mediaNotas=somaNotas/turma.Length;

        for(int i=0;i<turma.Length;i++){
            if(turma[i]>mediaNotas){
                acimaMedia++;
            }
        }
        Console.WriteLine($"\nA media da turma foi: {mediaNotas:F2}\nE os alunos acima da media somaram: {acimaMedia} alunos.");

    }
}

