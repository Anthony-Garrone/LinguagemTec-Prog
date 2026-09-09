using System;
using BibliotecaMatriz;
class Ex2
{
    static void Main()
    {
      Console.Write("Escreva o número de linhas da matriz: ");
      int linhas = int.Parse(Console.ReadLine());

      Console.Write("Escreva o número de colunas da matriz: ");
      int colunas = int.Parse(Console.ReadLine());

      int[,] matriz = new int[linhas, colunas];

      Console.WriteLine("\nEscreva os elementos da matriz:");
      Matriz.lerMatriz(matriz);

      Console.WriteLine("\nMatriz:");
      Matriz.mostrarMatriz(matriz);

      Console.WriteLine("\nMenor valor: " + Matriz.menorMatriz(matriz));

      Console.ReadKey();
    }
}