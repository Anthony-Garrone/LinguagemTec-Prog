using System;
using System.Collections.Generic;

class Emprestimo
{
    public string data;
    public string nomePessoa;
    public string emprestado;
}

class Jogo
{
    public string titulo;
    public string console;
    public int ano;
    public int ranking;
    public Emprestimo emprestimo;
}

class Program
{
    static void cadastrarJogos(List<Jogo> listaJogo)
    {
        Console.Write("Quantos jogos deseja cadastrar? ");
        int quantidade = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidade; i++)
        {
            Jogo novoJogo = new Jogo();

            Console.WriteLine("Jogo " + (i + 1));

            Console.Write("Título: ");
            novoJogo.titulo = Console.ReadLine();

            Console.Write("Console: ");
            novoJogo.console = Console.ReadLine();

            Console.Write("Ano: ");
            novoJogo.ano = int.Parse(Console.ReadLine());

            Console.Write("Ranking: ");
            novoJogo.ranking = int.Parse(Console.ReadLine());

            novoJogo.emprestimo = new Emprestimo();

            novoJogo.emprestimo.data = "";
            novoJogo.emprestimo.nomePessoa = "";
            novoJogo.emprestimo.emprestado = "N";

            listaJogo.Add(novoJogo);
        }
    }

    static void mostrarDadosJogo(Jogo jogo)
    {
        Console.WriteLine("Título: " + jogo.titulo);
        Console.WriteLine("Console: " + jogo.console);
        Console.WriteLine("Ano: " + jogo.ano);
        Console.WriteLine("Ranking: " + jogo.ranking);
        Console.WriteLine("Emprestado: " + jogo.emprestimo.emprestado);

        if (jogo.emprestimo.emprestado == "S")
        {
            Console.WriteLine("Data do empréstimo: " + jogo.emprestimo.data);
            Console.WriteLine("Nome da pessoa: " + jogo.emprestimo.nomePessoa);
        }
    }

    static bool buscarPorTitulo(List<Jogo> listaJogo, string tituloBusca)
    {
        bool encontrado = false;

        for (int i = 0; i < listaJogo.Count; i++)
        {
            if (listaJogo[i].titulo.ToUpper().Contains(tituloBusca.ToUpper()))
            {
                mostrarDadosJogo(listaJogo[i]);
                encontrado = true;
            }
        }

        return encontrado;
    }

    static bool buscarPorConsole(List<Jogo> listaJogo, string consoleBusca)
    {
        bool encontrado = false;

        for (int i = 0; i < listaJogo.Count; i++)
        {
            if (listaJogo[i].console.ToUpper().Contains(consoleBusca.ToUpper()))
            {
                mostrarDadosJogo(listaJogo[i]);
                Console.WriteLine();

                encontrado = true;
            }
        }

        return encontrado;
    }

    static bool realizarEmprestimo(List<Jogo> listaJogo, string tituloBusca)
    {
        for (int i = 0; i < listaJogo.Count; i++)
        {
            if (listaJogo[i].titulo.ToUpper().Contains(tituloBusca.ToUpper()))
            {
                if (listaJogo[i].emprestimo.emprestado == "N")
                {
                    Console.Write("Nome da pessoa que pegou o jogo: ");
                    listaJogo[i].emprestimo.nomePessoa = Console.ReadLine();

                    listaJogo[i].emprestimo.data = DateTime.Now.ToString("dd/MM/yyyy");
                    listaJogo[i].emprestimo.emprestado = "S";

                    Console.WriteLine("Empréstimo realizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Esse jogo já está emprestado.");
                }

                return true;
            }
        }

        return false;
    }

    static bool devolverJogo(List<Jogo> listaJogo, string tituloBusca)
    {
        for (int i = 0; i < listaJogo.Count; i++)
        {
            if (listaJogo[i].titulo.ToUpper().Contains(tituloBusca.ToUpper()))
            {
                if (listaJogo[i].emprestimo.emprestado == "S")
                {
                    listaJogo[i].emprestimo.emprestado = "N";

                    Console.WriteLine("Jogo devolvido com sucesso!");
                }
                else
                {
                    Console.WriteLine("Esse jogo não está emprestado.");
                }

                return true;
            }
        }

        return false;
    }

    static void mostrarJogosEmprestados(List<Jogo> listaJogo)
    {
        bool encontrado = false;

        Console.WriteLine("*** Jogos Emprestados ***");

        for (int i = 0; i < listaJogo.Count; i++)
        {
            if (listaJogo[i].emprestimo.emprestado == "S")
            {
                mostrarDadosJogo(listaJogo[i]);
                Console.WriteLine();

                encontrado = true;
            }
        }

        if (encontrado == false)
        {
            Console.WriteLine("Não há jogos emprestados.");
        }
    }

    static int menu()
    {
        Console.WriteLine("=== CONTROLE DE COLEÇÃO DE JOGOS ===");
        Console.WriteLine("1 - Cadastrar jogos");
        Console.WriteLine("2 - Buscar jogo por título");
        Console.WriteLine("3 - Listar jogos de um console");
        Console.WriteLine("4 - Realizar empréstimo");
        Console.WriteLine("5 - Devolver jogo");
        Console.WriteLine("6 - Mostrar jogos emprestados");
        Console.WriteLine("0 - Sair");

        Console.Write("Escolha uma opção: ");
        return int.Parse(Console.ReadLine());
    }

    static void Main()
    {
        List<Jogo> listaJogo = new List<Jogo>();

        int opcao;

        do
        {
            opcao = menu();

            switch (opcao)
            {
                case 1:
                    cadastrarJogos(listaJogo);
                    break;

                case 2:
                    Console.Write("Digite o título do jogo: ");
                    string tituloBusca = Console.ReadLine();

                    if (buscarPorTitulo(listaJogo, tituloBusca) == false)
                    {
                        Console.WriteLine("Jogo não encontrado.");
                    }

                    break;

                case 3:
                    Console.Write("Digite o console: ");
                    string consoleBusca = Console.ReadLine();

                    if (buscarPorConsole(listaJogo, consoleBusca) == false)
                    {
                        Console.WriteLine("Nenhum jogo encontrado.");
                    }

                    break;

                case 4:
                    Console.Write("Digite o título do jogo: ");
                    string tituloEmprestimo = Console.ReadLine();

                    if (realizarEmprestimo(listaJogo, tituloEmprestimo) == false)
                    {
                        Console.WriteLine("Jogo não encontrado.");
                    }

                    break;

                case 5:
                    Console.Write("Digite o título do jogo: ");
                    string tituloDevolucao = Console.ReadLine();

                    if (devolverJogo(listaJogo, tituloDevolucao) == false)
                    {
                        Console.WriteLine("Jogo não encontrado.");
                    }

                    break;

                case 6:
                    mostrarJogosEmprestados(listaJogo);
                    break;

                case 0:
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