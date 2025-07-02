using System;
using System.IO;
using System.Collections.Generic;

public class Program
{
    // Listas para armazenar os dados dos voos
    static List<string> codigos = new List<string>();
    static List<string> destinos = new List<string>();
    static List<int> disponiveis = new List<int>();
    static List<string[]> reservas = new List<string[]>();

    public static void Main()
    {
        int opcao = 0;
        while (opcao != 6)
        {
            Console.WriteLine("\nMenu Principal:");
            Console.WriteLine("1. Importar dados dos voos");
            Console.WriteLine("2. Realizar reserva");
            Console.WriteLine("3. Cancelar reserva");
            Console.WriteLine("4. Consultar assentos disponíveis ");
            Console.WriteLine("5. Relatório de ocupação de voos(de um especifico)");
            Console.WriteLine("6. Sair");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            // Menu de opções usando switch
            switch (opcao)
            {
                case 1:
                    Importar();
                    break;
                case 2:
                    RealizarReserva();
                    break;
                case 3:
                    CancelarReserva();
                    break;
                case 4:
                    ConsultarAssentosDisponiveis();
                    break;
                case 5:
                    RelatorioOcupacao();
                    break;
                case 6:
                    SalvarAlteracoes();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    // Lê os dados do arquivo e popula as listas
    static void Importar()
    {
        if (!File.Exists("registro.txt"))
        {
            Console.WriteLine("Arquivo 'registro.txt' não encontrado.");
            return;
        }

        // Limpa os dados antigos
        codigos.Clear();
        destinos.Clear();
        disponiveis.Clear();
        reservas.Clear();

        string[] linhas = File.ReadAllLines("registro.txt");
        int i = 0;

        while (i < linhas.Length)
        {
            if (linhas[i].StartsWith("Voo "))
            {
                // Captura código e destino do voo
                string[] partes = linhas[i].Split("- Destino: ");
                string cod = partes[0].Replace("Voo ", "").Trim();
                string destino = partes[1].Trim();

                codigos.Add(cod);
                destinos.Add(destino);
                disponiveis.Add(0);

                string[] assentos = new string[50];

                // Processa os próximos 50 assentos
                for (int j = 0; j < 50 && (i + 1 + j) < linhas.Length; j++)
                {
                    string linhaAssento = linhas[i + 1 + j];
                    string status = linhaAssento.Split(':')[1].Trim();

                    if (status == "Disponível")
                    {
                        assentos[j] = null;
                        disponiveis[disponiveis.Count - 1]++;
                    }
                    else
                    {
                        assentos[j] = status;
                    }
                }

                reservas.Add(assentos);
                i += 51; // Pula para o próximo voo
            }
            else
            {
                i++; // Ignora linhas inválidas
            }
        }

        Console.WriteLine($"Importados {codigos.Count} voos com sucesso.");
    }

    // Retorna a posição do voo pelo código
    static int PosicaoVoo(string codigo)
    {
        return codigos.IndexOf(codigo);
    }

    // Faz a reserva de assento
    static void RealizarReserva()
    {
        if (codigos.Count == 0)
        {
            Console.WriteLine("Importe os dados dos voos primeiro.");
            return;
        }

        Console.Write("Informe o código do voo: ");
        string codigo = Console.ReadLine();
        int posicao = PosicaoVoo(codigo);

        if (posicao == -1)
        {
            Console.WriteLine("Voo não encontrado.");
            return;
        }

        Console.Write("Informe o número do assento (1 a 50): ");
        int assento = int.Parse(Console.ReadLine()) - 1;

        if (assento < 0 || assento >= 50)
        {
            Console.WriteLine("Assento inválido.");
            return;
        }

        if (reservas[posicao][assento] != null)
        {
            Console.WriteLine("Assento já reservado.");
            return;
        }

        Console.Write("Informe o nome do passageiro: ");
        string nome = Console.ReadLine();
        reservas[posicao][assento] = nome;
        disponiveis[posicao]--;
        Console.WriteLine("Reserva realizada com sucesso!");
    }

    // Cancela a reserva de um assento
    static void CancelarReserva()
    {
        if (codigos.Count == 0)
        {
            Console.WriteLine("Importe os dados dos voos primeiro.");
            return;
        }

        Console.Write("Informe o código do voo: ");
        string codigo = Console.ReadLine();
        int posicao = PosicaoVoo(codigo);

        if (posicao == -1)
        {
            Console.WriteLine("Voo não encontrado.");
            return;
        }

        Console.Write("Informe o número do assento (1 a 50): ");
        int assento = int.Parse(Console.ReadLine()) - 1;

        if (assento < 0 || assento >= 50)
        {
            Console.WriteLine("Assento inválido.");
            return;
        }

        if (reservas[posicao][assento] == null)
        {
            Console.WriteLine("O assento já está disponível.");
            return;
        }

        reservas[posicao][assento] = null;
        disponiveis[posicao]++;
        Console.WriteLine("Reserva cancelada com sucesso!");
    }

    // Mostra assentos livres de cada voo
    static void ConsultarAssentosDisponiveis()
    {
        for (int i = 0; i < codigos.Count; i++)
        {
            Console.WriteLine($"\nVoo {codigos[i]} - Destino: {destinos[i]}");
            Console.Write("Assentos disponíveis: ");

            for (int j = 0; j < 50; j++)
            {
                if (reservas[i][j] == null)
                    Console.Write((j + 1) + ", ");
            }
            Console.WriteLine();
        }
    }

    // Detalha ocupação de um voo
    static void RelatorioOcupacao()
    {
        Console.Write("Informe o código do voo: ");
        string codigo = Console.ReadLine();
        int posicao = PosicaoVoo(codigo);

        if (posicao == -1)
        {
            Console.WriteLine("Voo não encontrado.");
            return;
        }

        Console.WriteLine($"\nVoo {codigos[posicao]} - Destino: {destinos[posicao]}");
        for (int j = 0; j < 50; j++)
        {
            if (reservas[posicao][j] == null)
                Console.WriteLine($"Assento {j + 1}: Disponível");
            else
                Console.WriteLine($"Assento {j + 1}: {reservas[posicao][j]}");
        }

        Console.WriteLine($"Total de reservados: {50 - disponiveis[posicao]} | Disponíveis: {disponiveis[posicao]}");
    }

    // Salva os dados atualizados no arquivo
    static void SalvarAlteracoes()
    {
        StreamWriter sw = new StreamWriter("registro.txt");

        for (int i = 0; i < codigos.Count; i++)
        {
            sw.WriteLine($"\nVoo {codigos[i]} - Destino: {destinos[i]}");

            for (int j = 0; j < 50; j++)
            {
                if (reservas[i][j] == null)
                    sw.WriteLine($"Assento {j + 1}: Disponível");
                else
                    sw.WriteLine($"Assento {j + 1}: {reservas[i][j]}");
            }
        }

        sw.Close();
        Console.WriteLine("Alterações salvas no arquivo 'registro.txt'.");
    }
}
