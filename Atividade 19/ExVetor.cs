using System;
using BibliotecaVetor;
class ExVetor
{
    static double calcularMedia(int[] roubos)
    {
        double soma = 0;

        for (int i = 0; i < roubos.Length; i++)
        {
            soma += roubos[i];
        }

        double media = soma / roubos.Length;

        return media;
    }

    static void exibirTop3BairrosViolentos(string[] bairros, int[] roubos)
    {
        bool[] usado = new bool[roubos.Length];

        for (int posicao = 0; posicao < 3; posicao++)
        {
            int maior = -1;
            int indiceMaior = -1;

            for (int i = 0; i < roubos.Length; i++)
            {
                if (!usado[i] && roubos[i] > maior)
                {
                    maior = roubos[i];
                    indiceMaior = i;
                }
            }

            usado[indiceMaior] = true;

            Console.WriteLine((posicao + 1) + "º Lugar: " + bairros[indiceMaior] + " (Índice " + indiceMaior + ") - " +
            roubos[indiceMaior] + " roubos");
        }
    }

    static void Main()
    {
        string[] bairros = {"Centro", "Moema", "Pinheiros", "Itaquera", "Tatuapé", "Santo Amaro", "Vila Mariana",
        "Lapa", "Capão Redondo", "Santana"};

        int[] vetorRoubos = new int[10];

        Vetor.lerVetor(vetorRoubos);

        Console.WriteLine();
        Console.WriteLine("Dados do Vetor:");

        for (int i = 0; i < vetorRoubos.Length; i++)
        {
            Console.Write("|" + vetorRoubos[i]);
        }

        Console.WriteLine("|");

        double media = calcularMedia(vetorRoubos);

        Console.WriteLine("Média de roubos: " + media.ToString("F2") + " ocorrências");
        Console.WriteLine("--- TOP 3 BAIRROS MAIS VIOLENTOS ---");

        exibirTop3BairrosViolentos(bairros, vetorRoubos);
    }
}