using System;
using BibliotecaVetor;
class Ex2
{
    public static int contarImpares(int[] vetor)
    {
        int quantidade = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] % 2 != 0)
            {
                quantidade++;
            }
        }

        return quantidade;
    }

    static void Main(string[] args)
    {
        Console.Write("Digite o tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine());

        int[] vetor = new int[n];

        Vetor.lerVetor(vetor);

        int quantidade = contarImpares(vetor);

        Console.WriteLine("Quantidade de impares = " + quantidade);
    }
}