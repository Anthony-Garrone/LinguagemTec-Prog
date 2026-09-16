using System;
using BibliotecaVetor;
class Ex7
{
    public static int contarValor(int[] vetor, int valor)
    {
        int quantidade = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == valor)
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

        Console.Write("Digite o valor que deseja procurar: ");
        int valor = int.Parse(Console.ReadLine());

        int quantidade = contarValor(vetor, valor);

        Vetor.mostrarVetor(vetor);

        Console.WriteLine();
        Console.WriteLine("O valor aparece " + quantidade + " vezes.");
    }
}
