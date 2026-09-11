using System;
using BibliotecaMatriz;

class Ex8
{
    static void Main()
    {
        int[,] marcado = new int[501, 501];

        Console.Write("Digite a quantidade de raios: ");
        int N = int.Parse(Console.ReadLine());

        int repetido = 0;

        for (int i = 0; i < N; i++)
        {
          Console.Write("Digite X e Y: ");
          string[] entrada = Console.ReadLine().Split();

          int X = int.Parse(entrada[0]);
          int Y = int.Parse(entrada[1]);

          if (marcado[X, Y] == 1)
        {
            repetido = 1;
        }
          else
        {
            marcado[X, Y] = 1;
        }
      }
        Console.WriteLine(repetido);
    }
}