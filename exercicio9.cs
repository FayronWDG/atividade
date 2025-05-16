using System;

public class Ex9
{

    public static void Rodar()
    {
        // Declaração das variáveis
        int horaInicio=24, minutoInicio = 70, horaFim=24, minutoFim=70;
        int duracaoHoras = 0, duracaoMinutos = 0;

        //titulo
        Console.WriteLine("Tempo de uma partida.");

        // Entrada de dados
        Console.WriteLine("Informe o horário de início do jogo\n");
        while(horaInicio > 23 || horaInicio<0)
        {
            Console.Write("Hora inicial: ");
            horaInicio = int.Parse(Console.ReadLine());
        }

         
        while (minutoInicio > 59 || minutoInicio < 0)
        {
            Console.Write("\nMinuto inicial: ");
            minutoInicio = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("\n\nInforme o horário de término do jogo\n");
        while (horaFim > 23 || horaFim < 0)
        {
            Console.Write("Hora final: ");
            horaFim = int.Parse(Console.ReadLine());
        }
        while (minutoFim > 59 || minutoFim < 0)
        {
            Console.Write("\nMinuto final: ");
            minutoFim = int.Parse(Console.ReadLine());
        }
        // Chama o procedimento para calcular a duração
        CalcularDuracao(horaInicio, minutoInicio, horaFim, minutoFim, ref duracaoHoras, ref duracaoMinutos);

        // Exibe o resultado
        Console.WriteLine($"\n\nO jogo durou {duracaoHoras} hora(s) e {duracaoMinutos} minuto(s).");

    }        
    
     public static void CalcularDuracao(int horaInicio, int minutoInicio, int horaFim, int minutoFim, ref int duracaoHoras, ref int duracaoMinutos)
    {
        // Converte as horas e minutos para minutos totais
        int inicioTotalMinutos = horaInicio * 60 + minutoInicio;
        int fimTotalMinutos = horaFim * 60 + minutoFim;

        // Se o horário de término for anterior ao de início, adiciona 24 horas (1440 minutos)
        if (fimTotalMinutos < inicioTotalMinutos)
        {

            fimTotalMinutos += 1440; 
        }

        // Calcula a diferença em minutos
        int duracaoTotalMinutos = fimTotalMinutos - inicioTotalMinutos;

        // Converte a duração total de minutos para horas e minutos
        duracaoHoras = duracaoTotalMinutos / 60;
        duracaoMinutos = duracaoTotalMinutos % 60;
    }
}
