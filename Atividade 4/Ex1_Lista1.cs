using System;

class Ex1_Lista1
{
    static int somarVetor(int[] vetor)
    {
        int soma = 0;
        for(int i = 0; i < vetor.Length; i++)
        {
            soma = soma + vetor[i];
        }// fim for
        return soma;
    }
    static void gerarVetor(int[] vetor)
    {
        Random aleatorio = new Random();
        for(int i = 0; i < vetor.Length; i++)
        vetor[i] = aleatorio.Next(1, 100);
    }

    static void mostrarVetor(int[] vetor)
    {
        Console.WriteLine("[Funcao]Dados do Vetor:");
        for(int i = 0; i < vetor.Length; i++)
        Console.Write("|" + vetor[i]);
        Console.WriteLine("|");
    }

    static void Main()
    {
        int N, soma;

        Console.WriteLine("Entre com o tamanho do Vetor:");
        N = int.Parse(Console.ReadLine());

        int[] meuArray =  new int[N];

        gerarVetor(meuArray);
        mostrarVetor(meuArray);

        soma = somarVetor(meuArray);

        Console.WriteLine("A soma dos elementos do Vetor é: " + soma);
    }
}