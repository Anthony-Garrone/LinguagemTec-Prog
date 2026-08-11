using System;

class Vetores{
    static void Main()
    {
        int[] meuArray = new int[5];
        Console.WriteLine("Entre com os dados do vetor:");
        for(int i = 0; i < meuArray.Length; i++)
        {
            Console.Write($"Array[{i}]:");
            meuArray[i] = int.Parse(Console.ReadLine());
        }// fim for
        Console.WriteLine("Dados do Vetor:");
        for(int i=0; i < meuArray.Length; i++)
        Console.Write("|" + meuArray[i]);
        Console.WriteLine("|");
    }
}