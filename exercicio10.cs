using System;
using System.IO;

public class Ex10
{
    public static void rodar()
    {
        //declara as variáveis que vão receber os resultados
        double maior = 0, menor = 0, media = 0;

        //título
        Console.WriteLine("Cálculo do maior, menor e média de valores do arquivo");        
        
        //chama a função que calcula tudo de uma vez e mostra os resultados na tela
        calcularTudo(ref maior, ref menor, ref media);
        exibir(maior, menor, media);
    }



    //função que calcula o maior, menor e a média dos números do arquivo valores.txt
    public static void calcularTudo(ref double maior, ref double menor, ref double media)
    {
        //abre o arquivo para leitura
        StreamReader sr = new StreamReader("valores.txt");

        //declarando variaveis
        string linha = sr.ReadLine();
        double soma = 0;
        int cont = 0;

        //enquanto houver linhas no arquivo
        while (linha != null)
        {
            if (linha != "")
            {
            
            double num = double.Parse(linha);

            }
            //se for o primeiro número, define como maior e menor
            if (cont == 0)
            {
                maior = num;
                menor = num;
            }
            else
            {
                
                if (num > maior)
                {
                    maior = num;
                }

              
                if (num < menor)
                {
                    menor = num;
                }
            }

        
            soma += num;

            
            cont++;

            
            linha = sr.ReadLine();
        }

        //fecha o arquivo após leitura
        sr.Close();

        
        
        
        media = soma / cont;
    }



    //função que mostra os resultados na tela
    public static void exibir(double max, double min, double media)
    {
        Console.WriteLine("Maior: " + max);
        Console.WriteLine("Menor: " + min);
        Console.WriteLine("Média: " + media);
    }
}
