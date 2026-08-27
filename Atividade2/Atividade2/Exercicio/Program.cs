using System;
class Program
{
    static void Main()
    {
        int[] numeros = new int[5];
        int busca;
        bool encontrou = false;
        for (int i = 0; i < numeros.Length; i++)
        {
        Console.Write($"Digite o valor da posição {i}: ");
        numeros[i] = int.Parse(Console.ReadLine()!);
        }
        // ler valor para busca
        Console.Write("Entre com um valor para busca:");
        busca = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < numeros.Length; i++)
        {
            if(busca == numeros[i])
            {
                Console.WriteLine($"Valor encontrado na posição {i}");
                encontrou = true;
                //break;
            }
        }
        if(!encontrou) // encontrou==false
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