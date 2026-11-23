using System;
using System.Collections.Generic;

class Livro
{
    public string titulo;
    public string autor;
    public int ano;
    public string prateleira;
}

class Program
{
    static void cadastrarLivro(List<Livro> listaLivro)
    {
        Livro novoLivro = new Livro();

        Console.WriteLine("Título: ");
        novoLivro.titulo = Console.ReadLine();

        Console.WriteLine("Autor: ");
        novoLivro.autor = Console.ReadLine();

        Console.WriteLine("Ano: ");
        novoLivro.ano = int.Parse(Console.ReadLine());

        Console.WriteLine("Prateleira: ");
        novoLivro.prateleira = Console.ReadLine();

        listaLivro.Add(novoLivro);

        Console.WriteLine("Livro cadastrado com sucesso!");
    }

    static void mostrarLivros(List<Livro> listaLivro)
    {
        Console.WriteLine("*** Livros Cadastrados ***");

        for (int i = 0; i < listaLivro.Count; i++)
        {
            Console.WriteLine("Livro " + (i + 1));
            Console.WriteLine("Título: " + listaLivro[i].titulo);
            Console.WriteLine("Autor: " + listaLivro[i].autor);
            Console.WriteLine("Ano: " + listaLivro[i].ano);
            Console.WriteLine("Prateleira: " + listaLivro[i].prateleira);
            Console.WriteLine();
        }
    }

    static bool buscarPorTitulo(List<Livro> listaLivro, string tituloBusca)
    {
        bool encontrado = false;

        for (int i = 0; i < listaLivro.Count; i++)
        {
            if (listaLivro[i].titulo.ToUpper().Contains(tituloBusca.ToUpper()))
            {
                Console.WriteLine("Título: " + listaLivro[i].titulo);
                Console.WriteLine("Autor: " + listaLivro[i].autor);
                Console.WriteLine("Ano: " + listaLivro[i].ano);
                Console.WriteLine("Prateleira: " + listaLivro[i].prateleira);

                encontrado = true;
            }
        }

        return encontrado;
    }

    static bool buscarMaisNovos(List<Livro> listaLivro, int anoBusca)
    {
        bool encontrado = false;

        for (int i = 0; i < listaLivro.Count; i++)
        {
            if (listaLivro[i].ano > anoBusca)
            {
                Console.WriteLine("Título: " + listaLivro[i].titulo);
                Console.WriteLine("Autor: " + listaLivro[i].autor);
                Console.WriteLine("Ano: " + listaLivro[i].ano);
                Console.WriteLine("Prateleira: " + listaLivro[i].prateleira);
                Console.WriteLine();

                encontrado = true;
            }
        }

        return encontrado;
    }

    static int menu()
    {
        Console.WriteLine("=== SISTEMA DE BIBLIOTECA ===");
        Console.WriteLine("1 - Cadastrar livro");
        Console.WriteLine("2 - Buscar livro por título");
        Console.WriteLine("3 - Mostrar todos os livros");
        Console.WriteLine("4 - Mostrar livros mais novos que um ano");
        Console.WriteLine("0 - Sair");

        Console.Write("Escolha uma opção: ");
        return int.Parse(Console.ReadLine());
    }

    static void Main()
    {
        List<Livro> listaLivro = new List<Livro>();

        int opcao;

        do
        {
            opcao = menu();

            switch (opcao)
            {
                case 1:
                    cadastrarLivro(listaLivro);
                    break;

                case 2:
                    Console.Write("Digite o título que deseja buscar: ");
                    string tituloBusca = Console.ReadLine();

                    if (buscarPorTitulo(listaLivro, tituloBusca) == false)
                    {
                        Console.WriteLine("Livro não encontrado.");
                    }

                    break;

                case 3:
                    mostrarLivros(listaLivro);
                    break;

                case 4:
                    Console.Write("Digite o ano: ");
                    int anoBusca = int.Parse(Console.ReadLine());

                    if (buscarMaisNovos(listaLivro, anoBusca) == false)
                    {
                        Console.WriteLine("Nenhum livro encontrado.");
                    }

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