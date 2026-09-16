using System;
class Ex5
{
    public static bool buscarValor(int[] numeros, int busca)
    {
        bool encontrou = false;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (busca == numeros[i])
            {
                Console.WriteLine($"Valor encontrado na posição {i}");
                encontrou = true;
            }
        }

        return encontrou;
    }

    static void Main()
    {
        int[] numeros = new int[5];
        int busca;

        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o valor da posição {i}: ");
            numeros[i] = int.Parse(Console.ReadLine()!);
        }

        // ler valor para busca
        Console.Write("Entre com um valor para busca: ");
        busca = int.Parse(Console.ReadLine()!);

        bool encontrou = buscarValor(numeros, busca);

        if (!encontrou) // encontrou == false
            Console.WriteLine("Valor não encontrado");

        // mostrando vetor
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"| {numeros[i]} ");
        }

        // mostrar dados
        Console.ReadKey();
    }
}