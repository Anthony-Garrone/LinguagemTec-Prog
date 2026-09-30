using System;
using BibliotecaMatriz;

class Ex5
{
    static int contarX(int[,] matriz, int x)
    {
        int contador = 0;

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] == x)
                {
                    contador++;
                }
            }
        }

        return contador;
    }

    static void Main()
    {
        int[,] matriz = new int[4, 4];

        Matriz.lerMatriz(matriz);
        Matriz.mostrarMatriz(matriz);

        Console.Write("Digite o valor X: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Quantidade de ocorrências: " + contarX(matriz, x));
    }
}