using System;
using BibliotecaMatriz;

class Ex9
{
    static void Main()
    {
        Console.Write("Digite o número de regiões: ");
        int R = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de cidades: ");
        int C = int.Parse(Console.ReadLine());

        int[,] matriz = new int[R, C];

        Matriz.gerarMatriz(matriz);

        Console.WriteLine();
        Console.WriteLine("Matriz das Tropas (Quantidade de Tropas por Cidade): ");

        for (int i = 0; i < R; i++)
        {
          Console.Write("Região " + (i + 1) + ": ");

          for (int j = 0; j < C; j++)
        {
          Console.Write(matriz[i, j] + " ");
        }

          Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("Força Total das Regiões: ");

        for (int i = 0; i < R; i++)
        {
          int soma = 0;

          for (int j = 0; j < C; j++)
        {
          soma = soma + matriz[i, j];
        }
          Console.WriteLine("Região " + (i + 1) + ": " + soma + " tropas");
        }
    }
}