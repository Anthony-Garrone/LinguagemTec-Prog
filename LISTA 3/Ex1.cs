using System;
using System.Collections.Generic;
using System.IO;

class Banda
{
    public string nome;
    public string genero;
    public int numeroIntegrantes;
    public int ranking;
}

class Program
{
    static void lerDadosBanda(Banda banda)
    {
        Console.WriteLine("Nome da banda: ");
        banda.nome = Console.ReadLine();

        Console.WriteLine("Gênero musical: ");
        banda.genero = Console.ReadLine();

        Console.WriteLine("Número de integrantes: ");
        banda.numeroIntegrantes = int.Parse(Console.ReadLine());

        Console.WriteLine("Posição no ranking: ");
        banda.ranking = int.Parse(Console.ReadLine());
    }

    static void cadastrarBanda(List<Banda> listaBanda)
    {
        Banda novaBanda = new Banda();
        lerDadosBanda(novaBanda);
        listaBanda.Add(novaBanda);

        Console.WriteLine("Banda cadastrada com sucesso!");
    }

    static void mostrarDadosBanda(Banda banda)
    {
        Console.WriteLine("Nome: " + banda.nome);
        Console.WriteLine("Gênero: " + banda.genero);
        Console.WriteLine("Número de integrantes: " + banda.numeroIntegrantes);
        Console.WriteLine("Ranking: " + banda.ranking);
    }

    static void mostrarBandas(List<Banda> listaBanda)
    {
        Console.WriteLine("*** Bandas Cadastradas ***");

        for (int i = 0; i < listaBanda.Count; i++)
        {
            Console.WriteLine("Banda " + (i + 1));
            mostrarDadosBanda(listaBanda[i]);
            Console.WriteLine();
        }
    }

    static bool buscarPorRanking(List<Banda> listaBanda, int rankingBusca)
    {
        bool encontrado = false;

        for (int i = 0; i < listaBanda.Count; i++)
        {
            if (listaBanda[i].ranking == rankingBusca)
            {
                mostrarDadosBanda(listaBanda[i]);
                encontrado = true;
            }
        }

        return encontrado;
    }

    static bool buscarPorGenero(List<Banda> listaBanda, string generoBusca)
    {
        bool encontrado = false;

        for (int i = 0; i < listaBanda.Count; i++)
        {
            if (listaBanda[i].genero.ToUpper().Contains(generoBusca.ToUpper()))
            {
                mostrarDadosBanda(listaBanda[i]);
                Console.WriteLine();

                encontrado = true;
            }
        }

        return encontrado;
    }

    static bool buscarPorNome(List<Banda> listaBanda, string nomeBusca)
    {
        bool encontrado = false;

        for (int i = 0; i < listaBanda.Count; i++)
        {
            if (listaBanda[i].nome.ToUpper().Contains(nomeBusca.ToUpper()))
            {
                mostrarDadosBanda(listaBanda[i]);
                encontrado = true;
            }
        }

        return encontrado;
    }

    static bool excluirBanda(List<Banda> listaBanda, string nomeBusca)
    {
        for (int i = 0; i < listaBanda.Count; i++)
        {
            if (listaBanda[i].nome.ToUpper() == nomeBusca.ToUpper())
            {
                listaBanda.RemoveAt(i);
                return true;
            }
        }

        return false;
    }

    static bool alterarBanda(List<Banda> listaBanda, string nomeBusca)
    {
        for (int i = 0; i < listaBanda.Count; i++)
        {
            if (listaBanda[i].nome.ToUpper() == nomeBusca.ToUpper())
            {
                Console.WriteLine("Digite os novos dados da banda:");
                lerDadosBanda(listaBanda[i]);

                return true;
            }
        }

        return false;
    }

    static void salvarDados(List<Banda> listaBanda, string nomeArquivo)
    {
        StreamWriter writer = new StreamWriter(nomeArquivo);

        foreach (Banda b in listaBanda)
        {
            writer.WriteLine($"{b.nome};{b.genero};{b.numeroIntegrantes};{b.ranking}");
        }

        writer.Dispose();

        Console.WriteLine("Dados salvos com sucesso!");
    }

    static void carregarDados(List<Banda> listaBanda, string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            listaBanda.Clear();

            string[] linhasDoArquivo = File.ReadAllLines(nomeArquivo);

            foreach (string linha in linhasDoArquivo)
            {
                string[] campos = linha.Split(';');

                Banda b = new Banda();

                b.nome = campos[0];
                b.genero = campos[1];
                b.numeroIntegrantes = int.Parse(campos[2]);
                b.ranking = int.Parse(campos[3]);

                listaBanda.Add(b);
            }

            Console.WriteLine("Dados carregados com sucesso!");
        }
        else
        {
            Console.WriteLine("Arquivo não encontrado :(");
        }
    }

    static int menu()
    {
        Console.WriteLine("=== CADASTRO DE BANDAS ===");
        Console.WriteLine("1 - Cadastrar banda");
        Console.WriteLine("2 - Listar todas as bandas");
        Console.WriteLine("3 - Buscar por posição no ranking");
        Console.WriteLine("4 - Buscar por gênero musical");
        Console.WriteLine("5 - Buscar por nome");
        Console.WriteLine("6 - Excluir banda");
        Console.WriteLine("7 - Alterar dados de uma banda");
        Console.WriteLine("8 - Carregar dados do arquivo");
        Console.WriteLine("9 - Salvar dados no arquivo");
        Console.WriteLine("0 - Sair");

        Console.Write("Escolha uma opção: ");
        return int.Parse(Console.ReadLine());
    }

    static void Main()
    {
        List<Banda> listaBanda = new List<Banda>();

        carregarDados(listaBanda, "bandas.txt");

        int opcao;

        do
        {
            opcao = menu();

            switch (opcao)
            {
                case 1:
                    cadastrarBanda(listaBanda);
                    break;

                case 2:
                    mostrarBandas(listaBanda);
                    break;

                case 3:
                    Console.Write("Digite a posição do ranking: ");
                    int rankingBusca = int.Parse(Console.ReadLine());

                    if (buscarPorRanking(listaBanda, rankingBusca) == false)
                    {
                        Console.WriteLine("Nenhuma banda encontrada.");
                    }

                    break;

                case 4:
                    Console.Write("Digite o gênero musical: ");
                    string generoBusca = Console.ReadLine();

                    if (buscarPorGenero(listaBanda, generoBusca) == false)
                    {
                        Console.WriteLine("Nenhuma banda encontrada.");
                    }

                    break;

                case 5:
                    Console.Write("Digite o nome da banda: ");
                    string nomeBusca = Console.ReadLine();

                    if (buscarPorNome(listaBanda, nomeBusca) == false)
                    {
                        Console.WriteLine("Banda não encontrada.");
                    }

                    break;

                case 6:
                    Console.Write("Digite o nome da banda que deseja excluir: ");
                    string nomeExcluir = Console.ReadLine();

                    if (excluirBanda(listaBanda, nomeExcluir))
                    {
                        Console.WriteLine("Banda excluída com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Banda não encontrada.");
                    }

                    break;

                case 7:
                    Console.Write("Digite o nome da banda que deseja alterar: ");
                    string nomeAlterar = Console.ReadLine();

                    if (alterarBanda(listaBanda, nomeAlterar))
                    {
                        Console.WriteLine("Dados alterados com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Banda não encontrada.");
                    }

                    break;

                case 8:
                    carregarDados(listaBanda, "bandas.txt");
                    break;

                case 9:
                    salvarDados(listaBanda, "bandas.txt");
                    break;

                case 0:
                    salvarDados(listaBanda, "bandas.txt");
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            if (opcao != 0)
            {
                Console.ReadKey();
                Console.Clear();
            }

        } while (opcao != 0);
    }
}