using System;
namespace BibliotecaMatriz
{
    public class Matriz
{
    public static void gerarMatriz(int[,] matriz)
{
        Random random = new Random();

    int linhas = matriz.GetLength(0);
    int cols = matriz.GetLength(1);

    for (int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < cols; j++)
    {
            matriz[i, j] = random.Next(0, 100);
        }
    }
}
    public static void lerMatriz(int[,] matriz)
{
    int linhas = matriz.GetLength(0);
    int cols = matriz.GetLength(1);

    for (int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < cols; j++)
    {
            Console.Write($"[{i},{j}]:");
            matriz[i, j] = int.Parse(Console.ReadLine());
        }
    }
}
    public static void mostrarMatriz(int[,] matriz)
{
    int linhas = matriz.GetLength(0);
    int cols = matriz.GetLength(1);

    for (int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < cols; j++)
    {
        Console.Write($"|{matriz[i, j],3}");
    }

        Console.WriteLine();
    }
}
    public static int maiorMatriz(int[,] matriz)
{
    int linhas = matriz.GetLength(0);
    int cols = matriz.GetLength(1);

    int maior = matriz[0, 0];

    for (int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < cols; j++)
    {
        if (matriz[i, j] > maior)
    {
            maior = matriz[i, j];
        }
    }
    }

    return maior;
}
    public static int menorMatriz(int[,] matriz)
{
    int linhas = matriz.GetLength(0);
    int cols = matriz.GetLength(1);

    int menor = matriz[0, 0];

    for (int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < cols; j++)
    {
        if (matriz[i, j] < menor)
    {
            menor = matriz[i, j];
        }
    }
    }

            return menor;
        }
    }
}