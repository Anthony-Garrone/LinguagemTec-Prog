using System;
class Ex4
{
    public static double menorVetor(double[] vetor)
    {
        double menor = vetor[0];

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
            }
        }

        return menor;
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

        double menor = menorVetor(vetor);

        Console.WriteLine("Menor elemento = " + menor);
    }
}
