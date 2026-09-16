using System;
class Ex10
{
    public static int[] contarOcorrencias(int[] vetor)
    {
        int[] ocorrencias = new int[6];

        for (int i = 0; i < vetor.Length; i++)
        {
            ocorrencias[vetor[i] - 1]++;
        }

            return ocorrencias;
    }

    static void Main(string[] args)
    {
        Console.Write("Digite a quantidade de lancamentos: ");
        int n = int.Parse(Console.ReadLine());

        int[] vetor = new int[n];

        Random aleatorio = new Random();

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = aleatorio.Next(1, 7);
        }

        int[] ocorrencias = contarOcorrencias(vetor);

        Console.WriteLine("Ocorrencias:");

        for (int i = 0; i < ocorrencias.Length; i++)
        {
            Console.WriteLine("Face " + (i + 1) + ": " + ocorrencias[i]);
        }
    }
}
