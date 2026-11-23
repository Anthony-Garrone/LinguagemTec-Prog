using System;
using System.Collections.Generic;
using System.IO;

class Eletrodomestico
{
    public string nome;
    public double potencia;
    public double tempoAtivo;
}

class Program
{
    static void cadastrarEletrodomestico(List<Eletrodomestico> listaEletrodomestico)
    {
        Eletrodomestico novo = new Eletrodomestico();

        Console.WriteLine("Nome do eletrodoméstico: ");
        novo.nome = Console.ReadLine();

        Console.WriteLine("Potência (kW): ");
        novo.potencia = double.Parse(Console.ReadLine());

        Console.WriteLine("Tempo médio ativo por dia (horas): ");
        novo.tempoAtivo = double.Parse(Console.ReadLine());

        listaEletrodomestico.Add(novo);

        Console.WriteLine("Eletrodoméstico cadastrado com sucesso!");
    }

    static void mostrarEletrodomesticos(List<Eletrodomestico> listaEletrodomestico)
    {
        Console.WriteLine("*** Eletrodomésticos Cadastrados ***");

        for (int i = 0; i < listaEletrodomestico.Count; i++)
        {
            Console.WriteLine("Nome: " + listaEletrodomestico[i].nome);
            Console.WriteLine("Potência: " + listaEletrodomestico[i].potencia);
            Console.WriteLine("Tempo ativo: " + listaEletrodomestico[i].tempoAtivo);
            Console.WriteLine("Consumo diário: " + (listaEletrodomestico[i].potencia * listaEletrodomestico[i].tempoAtivo) + " kWh");
            Console.WriteLine();
        }
    }

    static bool buscarPorNome(List<Eletrodomestico> listaEletrodomestico, string nomeBusca)
    {
        bool encontrado = false;

        for (int i = 0; i < listaEletrodomestico.Count; i++)
        {
            if (listaEletrodomestico[i].nome.ToUpper().Contains(nomeBusca.ToUpper()))
            {
                Console.WriteLine("Nome: " + listaEletrodomestico[i].nome);
                Console.WriteLine("Potência: " + listaEletrodomestico[i].potencia);
                Console.WriteLine("Tempo ativo: " + listaEletrodomestico[i].tempoAtivo);

                encontrado = true;
            }
        }

        return encontrado;
    }

    static bool buscarPorConsumo(List<Eletrodomestico> listaEletrodomestico, double consumoX)
    {
        bool encontrado = false;

        for (int i = 0; i < listaEletrodomestico.Count; i++)
        {
            double consumoDiario = listaEletrodomestico[i].potencia * listaEletrodomestico[i].tempoAtivo;

            if (consumoDiario > consumoX)
            {
                Console.WriteLine("Nome: " + listaEletrodomestico[i].nome);
                Console.WriteLine("Consumo diário: " + consumoDiario + " kWh");

                encontrado = true;
            }
        }

        return encontrado;
    }

    static void calcularConsumoCasa(List<Eletrodomestico> listaEletrodomestico, double precoKwh)
    {
        double totalDiario = 0;
        double totalMensal = 0;

        for (int i = 0; i < listaEletrodomestico.Count; i++)
        {
            double consumoDiario = listaEletrodomestico[i].potencia * listaEletrodomestico[i].tempoAtivo;

            totalDiario = totalDiario + consumoDiario;
        }

        totalMensal = totalDiario * 30;

        double gastoDiario = totalDiario * precoKwh;
        double gastoMensal = totalMensal * precoKwh;

        Console.WriteLine("Consumo diário da casa: " + totalDiario + " kWh");
        Console.WriteLine("Consumo mensal da casa: " + totalMensal + " kWh");
        Console.WriteLine("Gasto diário: R$ " + gastoDiario);
        Console.WriteLine("Gasto mensal: R$ " + gastoMensal);
    }

    static void salvarDados(List<Eletrodomestico> listaEletrodomestico, string nomeArquivo)
    {
        StreamWriter writer = new StreamWriter(nomeArquivo);

        foreach (Eletrodomestico e in listaEletrodomestico)
        {
            writer.WriteLine($"{e.nome};{e.potencia};{e.tempoAtivo}");
        }

        writer.Dispose();

        Console.WriteLine("Dados salvos com sucesso!");
    }

    static void carregarDados(List<Eletrodomestico> listaEletrodomestico, string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            listaEletrodomestico.Clear();

            string[] linhasDoArquivo = File.ReadAllLines(nomeArquivo);

            foreach (string linha in linhasDoArquivo)
            {
                string[] campos = linha.Split(';');

                Eletrodomestico e = new Eletrodomestico();

                e.nome = campos[0];
                e.potencia = double.Parse(campos[1]);
                e.tempoAtivo = double.Parse(campos[2]);

                listaEletrodomestico.Add(e);
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
        Console.WriteLine("=== CONTROLE DE CONSUMO DE ENERGIA ===");
        Console.WriteLine("1 - Cadastrar eletrodoméstico");
        Console.WriteLine("2 - Listar eletrodomésticos");
        Console.WriteLine("3 - Buscar pelo nome");
        Console.WriteLine("4 - Buscar consumo maior que X");
        Console.WriteLine("5 - Calcular consumo e gasto da casa");
        Console.WriteLine("6 - Salvar dados");
        Console.WriteLine("7 - Carregar dados");
        Console.WriteLine("0 - Sair");

        Console.Write("Escolha uma opção: ");
        return int.Parse(Console.ReadLine());
    }

    static void Main()
    {
        List<Eletrodomestico> listaEletrodomestico = new List<Eletrodomestico>();

        carregarDados(listaEletrodomestico, "eletrodomesticos.txt");

        int opcao;

        do
        {
            opcao = menu();

            switch (opcao)
            {
                case 1:
                    cadastrarEletrodomestico(listaEletrodomestico);
                    break;

                case 2:
                    mostrarEletrodomesticos(listaEletrodomestico);
                    break;

                case 3:
                    Console.Write("Digite o nome do eletrodoméstico: ");
                    string nomeBusca = Console.ReadLine();

                    if (buscarPorNome(listaEletrodomestico, nomeBusca) == false)
                    {
                        Console.WriteLine("Eletrodoméstico não encontrado.");
                    }

                    break;

                case 4:
                    Console.Write("Digite o consumo mínimo (kWh): ");
                    double consumoX = double.Parse(Console.ReadLine());

                    if (buscarPorConsumo(listaEletrodomestico, consumoX) == false)
                    {
                        Console.WriteLine("Nenhum eletrodoméstico encontrado.");
                    }

                    break;

                case 5:
                    Console.Write("Digite o preço do kWh (R$): ");
                    double precoKwh = double.Parse(Console.ReadLine());

                    calcularConsumoCasa(listaEletrodomestico, precoKwh);
                    break;

                case 6:
                    salvarDados(listaEletrodomestico, "eletrodomesticos.txt");
                    break;

                case 7:
                    carregarDados(listaEletrodomestico, "eletrodomesticos.txt");
                    break;

                case 0:
                    salvarDados(listaEletrodomestico, "eletrodomesticos.txt");
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