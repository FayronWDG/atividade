using System;

public class Ex9
{

    public static void rodar()
    {   
        //declarando variaveis.
        int i = 0;
        //while que vai repetino até a pessoa digitar um número menor que 0
        while(i >= 0)
        {   
            //chama o procedimetno que faz o sorteio da frase e pergunta se a pessoa quer sair do programa.
            lerFraseMotivacional();
            Console.WriteLine("Se quiser sair digite qualquer número menor que 0.");
            i = int.Parse(Console.ReadLine());

        }

    }
    
    //função que lê uma frase aleatoria.
    public static void lerFraseMotivacional()
    {
        //declarando variaveis
        string[] frases = new string[10]; 
        int total = 0,sorteado=0;
        string[] partes;

        //abre o arquivo para leitura
        StreamReader sr = new StreamReader("frasesM.txt");

        //pega as frases dentro do arquivo
        string linha = sr.ReadLine();
        while (linha != null)
        {
            frases[total] = linha;
            total++;
            linha = sr.ReadLine();
        }

        //fecha o arquivo
        sr.Close();

        //cria objeto para sortear um número aleatorio e sorteia um número que vai ir e pegar lá nas frases separadas anteriormente.
        //e assim mostra na tela do usuario a frase que veio.
        Random r = new Random();
        sorteado = r.Next(total); 
        partes = frases[sorteado].Split(':');
        Console.WriteLine($"\nFrase sorteada: {partes[1]}\n");
        

    }
}
