using System;
using BibliotecaMatriz;

class Ex3
{
    static void Main()
    {
        Console.Write("Digite o tamanho da matriz: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, n];

        Matriz.gerarMatriz(matriz);
        Matriz.mostrarMatriz(matriz);

        Console.WriteLine("Diagonal Principal:");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(matriz[i, i]);
        }
    }
}