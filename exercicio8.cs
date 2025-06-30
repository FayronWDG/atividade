using System;
using System.IO;
using System.Text;

public class Ex8{

     public static void rodar()
    {

        Console.WriteLine();

        //chama a função para guardar um aluno e sua matricula e a função para procurar um aluno pela matricula.    
        guardarNovoAluno();
        procurarAlunoPorMatricula();  
    }


    //função que "cadastra" novo aluno no arquivo txt.
    public static void guardarNovoAluno(){
        //abre o arquivo para gravar nele
        StreamWriter sw = new StreamWriter("alunos.txt", true, Encoding.ASCII);
        //declarando variaveis
        int matricula=0;
        string continuar = "s",nome = "";
        //titulo a parte
        Console.WriteLine("Cadastro de Alunos.");

        while (continuar.ToLower() == "s")
        {

            
            
            Console.Write("Matrícula: ");
            matricula =int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            sw.WriteLine(matricula + ":" + nome);

            Console.Write("Deseja cadastrar outro aluno? (s/n): ");
            continuar = Console.ReadLine();
        }

        sw.Close();
    }




    // Função que lê o arquivo e retorna o nome do aluno com base na matrícula
    public static string matricula(int matriculaProcurada)
    {
        //abrindo arquivo para leitura
        StreamReader sr = new StreamReader("alunos.txt");
        //declarando variaveis
        int matricula = 0;
        string line = sr.ReadLine(),nome = "";

        while (line != null)
        {
            string[] dados = line.Split(':',' ');
            matricula =int.Parse(dados[0]);
            nome = dados[1];

            if (matricula == matriculaProcurada)
            {
                sr.Close();
                return nome;
            }

            line = sr.ReadLine();
        }

        sr.Close();
        return ""; 
    }



    //função para guardar nova matricula e aluno no alunos.txt
    public static void procurarAlunoPorMatricula(){

        string continuar = "s";
          while(continuar.ToLower() == "s")
        {
         //pedindo para o usuario digitar a matrícula para procurar o aluno
        Console.Write("\nDigite uma matrícula para buscar o nome do aluno: ");
        int matriculaBusca = int.Parse(Console.ReadLine());

        string resultado = matricula(matriculaBusca);
        
        Console.WriteLine("Aluno encontrado: " + resultado + "\n");

       
        //qualquer resposta além e s faz o while terminar
        Console.Write("Deseja procurar outro aluno? (s/n): ");
        continuar = Console.ReadLine();
        }
    }
}