using System;
using BibliotecaVetor;
class Ex6
{
    public static int[] multiplicarVetores(int[] vetor1, int[] vetor2)
    {
        int[] resultado = new int[vetor1.Length];

        for (int i = 0; i < vetor1.Length; i++)
        {
            resultado[i] = vetor1[i] * vetor2[i];
        }

        return resultado;
    }

    static void Main(string[] args)
    {
        Console.Write("Digite o tamanho dos vetores: ");
        int n = int.Parse(Console.ReadLine());

        int[] vetor1 = new int[n];
        int[] vetor2 = new int[n];

        Console.WriteLine("Primeiro vetor:");
        Vetor.lerVetor(vetor1);

        Console.WriteLine("Segundo vetor:");
        Vetor.lerVetor(vetor2);

        int[] resultado = multiplicarVetores(vetor1, vetor2);

        Console.WriteLine("Vetor resultante:");
        Vetor.mostrarVetor(resultado);
    }
}