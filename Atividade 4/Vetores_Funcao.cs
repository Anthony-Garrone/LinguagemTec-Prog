using System;

class Vetores_Funcao{

    static void lerVetor(int[] vetor)
    {
        Console.WriteLine("[Funcao]Entre com os dados do vetor:");
        for(int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Array[{i}]:");
            vetor[i] = int.Parse(Console.ReadLine());
        }// fim for
    }

    static void gerarVetor(int[] vetor)
    {
        Random aleatorio = new Random();
        for(int i = 0; i < vetor.Length; i++)
        vetor[i]= aleatorio.Next(1, 100);
    }
    static void mostrarVetor(int[] vetor)
    {
        Console.WriteLine("[Funcao]Dados do Vetor:");
        for(int i=0; i < vetor.Length; i++)
        Console.Write("|" + vetor[i]);
        Console.WriteLine("|");
    }
    static void Main()
    {
        int[] meuArray = new int[5];
        gerarVetor(meuArray);
        mostrarVetor(meuArray);   
    }
}