using System;

public class Ex7{

    public static void Rodar()
    {
        int nAlunos = 0;
        

        Console.WriteLine("\nMédia de notas de alunos.\n");

        Console.Write("Escreva o número de notas a ser lido: ");
        nAlunos = int.Parse(Console.ReadLine());

        Console.WriteLine($"(\nOs aprovados são os que tiraram de 6 pra cima)\nA média das notas dos alunos aprovados é {MediaNotas(nAlunos):F2}");
        
    }
    public static double MediaNotas(double contador)
    {
        double nota = 0, media = 0;
        for (int i = 0; i < contador; i++)
        
        {
            Console.Write($"Escreva a {i + 1}º nota: ");
            nota = double.Parse(Console.ReadLine());
            Console.WriteLine("for: "+nota);
            if (nota >= 6)
            {
                Console.WriteLine("Aprovado.");
                media += nota;
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }
        media = media / contador;
        return media;
    }
}
