using System;
using BibliotecaMatriz;

class Ex2
{
    static int menorValor(int[,] matriz)
    {
        int menor = matriz[0, 0];

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] < menor)
                {
                    menor = matriz[i, j];
                }
            }
        }

        return menor;
    }

    static void Main()
    {
        int[,] matriz = new int[3, 4];

        Matriz.lerMatriz(matriz);
        Matriz.mostrarMatriz(matriz);

        Console.WriteLine("Menor valor: " + menorValor(matriz));
    }
}