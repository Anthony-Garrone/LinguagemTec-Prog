using System;
using BibliotecaMatriz;

class Ex7
{
    static int[,] somarMatrizes(int[,] matriz1, int[,] matriz2)
    {
        if (matriz1.GetLength(0) != matriz2.GetLength(0) ||
            matriz1.GetLength(1) != matriz2.GetLength(1))
        {
            return null;
        }

        int linhas = matriz1.GetLength(0);
        int colunas = matriz1.GetLength(1);

        int[,] resultado = new int[linhas, colunas];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                resultado[i, j] = matriz1[i, j] + matriz2[i, j];
            }
        }

        return resultado;
    }

    static void Main()
    {
        int[,] matriz1 = new int[3, 3];
        int[,] matriz2 = new int[3, 3];

        Matriz.lerMatriz(matriz1);
        Matriz.lerMatriz(matriz2);

        int[,] resultado = somarMatrizes(matriz1, matriz2);

        if (resultado == null)
        {
            Console.WriteLine("As matrizes não possuem a mesma ordem.");
        }
        else
        {
            Console.WriteLine("Resultado:");
            Matriz.mostrarMatriz(resultado);
        }
    }
}