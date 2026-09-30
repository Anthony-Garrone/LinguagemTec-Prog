using System;
using BibliotecaMatriz;

class Ex11
{
    static void Main()
    {
        Console.Write("Digite o tamanho da matriz: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, n];

        Matriz.gerarMatriz(matriz);

        Console.WriteLine("Mapa do Tesouro:");
        Matriz.mostrarMatriz(matriz);

        int somaPrincipal = 0;
        int somaSecundaria = 0;

        for (int i = 0; i < n; i++)
        {
            somaPrincipal = somaPrincipal + matriz[i, i];

            somaSecundaria = somaSecundaria + matriz[i, n - 1 - i];
        }

        Console.WriteLine("Soma da Diagonal Principal: " + somaPrincipal);
        Console.WriteLine("Soma da Diagonal Secundária: " + somaSecundaria);

        if (somaPrincipal > somaSecundaria)
        {
            Console.WriteLine("O maior tesouro está na diagonal principal.");
        }
        else if (somaSecundaria > somaPrincipal)
        {
            Console.WriteLine("O maior tesouro está na diagonal secundária.");
        }
        else
        {
            Console.WriteLine("As duas diagonais possuem a mesma quantidade de moedas.");
        }
    }
}