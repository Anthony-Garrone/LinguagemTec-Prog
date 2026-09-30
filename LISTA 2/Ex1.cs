using System;
using BibliotecaMatriz;

class Ex1
{
    static int maiorValor(int[,] matriz)
    {
        int maior = matriz[0, 0];

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] > maior)
                {
                    maior = matriz[i, j];
                }
            }
        }

        return maior;
    }

    static void Main()
    {
        int[,] matriz = new int[3, 4];

        Matriz.lerMatriz(matriz);
        Matriz.mostrarMatriz(matriz);

        Console.WriteLine("Maior valor: " + maiorValor(matriz));
    }
}