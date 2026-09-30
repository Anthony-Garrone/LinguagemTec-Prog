using System;

class Ex6
{
    static void mostrarMatriz(double[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write("|" + matriz[i, j]);
            }

            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("Digite o número de linhas: ");
        int linhas = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de colunas: ");
        int colunas = int.Parse(Console.ReadLine());

        double[,] matriz1 = new double[linhas, colunas];
        double[,] matriz2 = new double[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write("Matriz 1 [" + i + "," + j + "]: ");
                matriz1[i, j] = double.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write("Matriz 2 [" + i + "," + j + "]: ");
                matriz2[i, j] = double.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Adicionar constante");
        Console.WriteLine("4 - Imprimir matrizes");

        Console.Write("Escolha uma opção: ");
        int opcao = int.Parse(Console.ReadLine());

        if (opcao == 1)
        {
            double[,] resultado = new double[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    resultado[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            Console.WriteLine("Resultado da soma:");
            mostrarMatriz(resultado);
        }
        else if (opcao == 2)
        {
            double[,] resultado = new double[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    resultado[i, j] = matriz1[i, j] - matriz2[i, j];
                }
            }

            Console.WriteLine("Resultado da subtração:");
            mostrarMatriz(resultado);
        }
        else if (opcao == 3)
        {
            Console.Write("Digite a constante: ");
            double constante = double.Parse(Console.ReadLine());

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    matriz1[i, j] = matriz1[i, j] + constante;
                    matriz2[i, j] = matriz2[i, j] + constante;
                }
            }
        }
        else if (opcao == 4)
        {
            Console.WriteLine("Matriz 1:");
            mostrarMatriz(matriz1);

            Console.WriteLine("Matriz 2:");
            mostrarMatriz(matriz2);
        }
    }
}