using System;
using BibliotecaMatriz;

class ExMatriz
{
    static double[] calcularPercentuaDesmatamento(int[,] matriz)
    {
        double[] percentuais = new double[3];

        double desmatada = 0;
        double parcial = 0;
        double preservada = 0;

        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matriz[i, j] == 0)
                {
                    desmatada++;
                }
                else if (matriz[i, j] == 1)
                {
                    parcial++;
                }
                else if (matriz[i, j] == 2)
                {
                    preservada++;
                }
            }
        }

        double total = linhas * cols;

        percentuais[0] = (desmatada / total) * 100;
        percentuais[1] = (parcial / total) * 100;
        percentuais[2] = (preservada / total) * 100;

        return percentuais;
    }

    static void analisarAumento(int[,] matrizAnterior, int[,] matrizAtual)
    {
        double[] percentualAnterior = calcularPercentuaDesmatamento(matrizAnterior);
        double[] percentualAtual = calcularPercentuaDesmatamento(matrizAtual);

        Console.WriteLine();
        Console.WriteLine("Percentual de ocorrências na matriz 6 meses atrás:");
        Console.WriteLine("Área Desmatada (Código 0): " + percentualAnterior[0].ToString("F2") + "%");

        Console.WriteLine();
        Console.WriteLine("Percentual de ocorrências na matriz atual:");
        Console.WriteLine("Área Desmatada (Código 0): " + percentualAtual[0].ToString("F2") + "%");

        if (percentualAtual[0] > percentualAnterior[0])
        {
            Console.WriteLine();
            Console.WriteLine("Houve Aumento no Desmatamento – Anterior " + percentualAnterior[0].ToString("F2") +
            "% -> Atual " + percentualAtual[0].ToString("F2") + "%");
        }
        else if (percentualAtual[0] < percentualAnterior[0])
        {
            Console.WriteLine();
            Console.WriteLine("Houve Redução no Desmatamento – Anterior " + percentualAnterior[0].ToString("F2") +
            "% -> Atual " + percentualAtual[0].ToString("F2") + "%");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("O Desmatamento Permaneceu Igual – Anterior " + percentualAnterior[0].ToString("F2") +
            "% -> Atual " + percentualAtual[0].ToString("F2") + "%");
        }
    }

    static void Main()
    {
        int[,] matrizAnterior = Matriz.carregarMatriz("dados_matriz_6meses_atras.csv");

        int[,] matrizAtual = Matriz.carregarMatriz("dados_matriz_atual.csv");

        Console.WriteLine("=== MONITORAMENTO DE DESMATAMENTO ===");

        Console.WriteLine();
        Console.WriteLine("MATRIZ DE 6 MESES ATRÁS:");
        Matriz.mostrarMatriz(matrizAnterior);

        Console.WriteLine();
        Console.WriteLine("MATRIZ ATUAL:");
        Matriz.mostrarMatriz(matrizAtual);

        analisarAumento(matrizAnterior, matrizAtual);
    }
}