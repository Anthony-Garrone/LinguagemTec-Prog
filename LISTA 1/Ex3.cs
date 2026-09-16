using System;
class Ex3
{
    public static double maiorVetor(double[] vetor)
    {
        double maior = vetor[0];

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
            }
        }

        return maior;
    }

    static void Main(string[] args)
    {
        Console.Write("Digite o tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine());

        double[] vetor = new double[n];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("Array[" + i + "]: ");
            vetor[i] = double.Parse(Console.ReadLine());
        }

        double maior = maiorVetor(vetor);

        Console.WriteLine("Maior elemento = " + maior);
    }
}
