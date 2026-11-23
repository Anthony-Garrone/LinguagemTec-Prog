using System;
using System.Collections.Generic;
using System.IO;

class Nascimento
{
    public int mes;
    public int ano;
}

class Gado
{
    public int codigo;
    public double leite;
    public double alim;
    public Nascimento nasc;
    public string abate;
}

class Program
{
    static void lerBaseDados(List<Gado> listaGado)
    {
        Console.Write("Quantidade de cabeças de gado: ");
        int quantidade = int.Parse(Console.ReadLine());

        listaGado.Clear();

        for (int i = 0; i < quantidade; i++)
        {
            Gado novoGado = new Gado();

            novoGado.nasc = new Nascimento();

            Console.WriteLine("Cabeça de gado " + (i + 1));

            Console.Write("Código: ");
            novoGado.codigo = int.Parse(Console.ReadLine());

            Console.Write("Litros de leite por semana: ");
            novoGado.leite = double.Parse(Console.ReadLine());

            Console.Write("Alimento por semana (kg): ");
            novoGado.alim = double.Parse(Console.ReadLine());

            Console.Write("Mês de nascimento: ");
            novoGado.nasc.mes = int.Parse(Console.ReadLine());

            Console.Write("Ano de nascimento: ");
            novoGado.nasc.ano = int.Parse(Console.ReadLine());

            novoGado.abate = "N";

            listaGado.Add(novoGado);
        }

        atualizarAbate(listaGado);
    }

    static void atualizarAbate(List<Gado> listaGado)
    {
        int mesAtual = DateTime.Now.Month;
        int anoAtual = DateTime.Now.Year;

        for (int i = 0; i < listaGado.Count; i++)
        {
            int diferencaAno = anoAtual - listaGado[i].nasc.ano;

            bool maisDeCincoAnos = false;

            if (diferencaAno > 5)
            {
                maisDeCincoAnos = true;
            }
            else if (diferencaAno == 5 && mesAtual > listaGado[i].nasc.mes)
            {
                maisDeCincoAnos = true;
            }

            if (maisDeCincoAnos || listaGado[i].leite < 40)
            {
                listaGado[i].abate = "S";
            }
            else
            {
                listaGado[i].abate = "N";
            }
        }
    }

    static void calcularTotalLeite(List<Gado> listaGado)
    {
        double totalLeite = 0;

        for (int i = 0; i < listaGado.Count; i++)
        {
            totalLeite = totalLeite + listaGado[i].leite;
        }

        Console.WriteLine("Total de leite produzido por semana: " + totalLeite + " litros");
    }

    static void calcularTotalAlimento(List<Gado> listaGado)
    {
        double totalAlimento = 0;

        for (int i = 0; i < listaGado.Count; i++)
        {
            totalAlimento = totalAlimento + listaGado[i].alim;
        }

        Console.WriteLine("Total de alimento consumido por semana: " + totalAlimento + " kg");
    }

    static void listarAnimaisAbate(List<Gado> listaGado)
    {
        bool encontrado = false;

        Console.WriteLine("*** Animais que devem ir para o abate ***");

        for (int i = 0; i < listaGado.Count; i++)
        {
            if (listaGado[i].abate == "S")
            {
                Console.WriteLine("Código: " + listaGado[i].codigo);
                Console.WriteLine("Leite por semana: " + listaGado[i].leite);
                Console.WriteLine("Alimento por semana: " + listaGado[i].alim);
                Console.WriteLine("Nascimento: " + listaGado[i].nasc.mes + "/" + listaGado[i].nasc.ano);
                Console.WriteLine("Abate: " + listaGado[i].abate);
                Console.WriteLine();

                encontrado = true;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine("Nenhum animal deve ir para o abate.");
        }
    }

    static void salvarDados(List<Gado> listaGado, string nomeArquivo)
    {
        StreamWriter writer = new StreamWriter(nomeArquivo);

        foreach (Gado g in listaGado)
        {
            writer.WriteLine($"{g.codigo};{g.leite};{g.alim};{g.nasc.mes};{g.nasc.ano};{g.abate}");
        }

        writer.Dispose();

        Console.WriteLine("Dados salvos com sucesso!");
    }

    static void carregarDados(List<Gado> listaGado, string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            listaGado.Clear();

            string[] linhasDoArquivo = File.ReadAllLines(nomeArquivo);

            foreach (string linha in linhasDoArquivo)
            {
                string[] campos = linha.Split(';');

                Gado g = new Gado();

                g.codigo = int.Parse(campos[0]);
                g.leite = double.Parse(campos[1]);
                g.alim = double.Parse(campos[2]);

                g.nasc = new Nascimento();

                g.nasc.mes = int.Parse(campos[3]);
                g.nasc.ano = int.Parse(campos[4]);

                g.abate = campos[5];

                listaGado.Add(g);
            }

            atualizarAbate(listaGado);

            Console.WriteLine("Dados carregados com sucesso!");
        }
        else
        {
            Console.WriteLine("Arquivo não encontrado :(");
        }
    }

    static int menu()
    {
        Console.WriteLine("=== CONTROLE DA FAZENDA DE GADO ===");
        Console.WriteLine("1 - Ler/cadastrar base de dados");
        Console.WriteLine("2 - Mostrar total de leite por semana");
        Console.WriteLine("3 - Mostrar total de alimento por semana");
        Console.WriteLine("4 - Listar animais que devem ir para o abate");
        Console.WriteLine("5 - Salvar dados");
        Console.WriteLine("6 - Carregar dados");
        Console.WriteLine("0 - Sair");

        Console.Write("Escolha uma opção: ");
        return int.Parse(Console.ReadLine());
    }

    static void Main()
    {
        List<Gado> listaGado = new List<Gado>();

        carregarDados(listaGado, "gado.txt");

        int opcao;

        do
        {
            opcao = menu();

            switch (opcao)
            {
                case 1:
                    lerBaseDados(listaGado);
                    break;

                case 2:
                    calcularTotalLeite(listaGado);
                    break;

                case 3:
                    calcularTotalAlimento(listaGado);
                    break;

                case 4:
                    listarAnimaisAbate(listaGado);
                    break;

                case 5:
                    salvarDados(listaGado, "gado.txt");
                    break;

                case 6:
                    carregarDados(listaGado, "gado.txt");
                    break;

                case 0:
                    salvarDados(listaGado, "gado.txt");
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