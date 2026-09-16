using System;
class Ex8
{
    public static void inverter(char[] vetor)
    {
        for (int i = vetor.Length - 1; i >= 0; i--)
        {
            Console.Write(vetor[i]);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Digite os caracteres: ");
        string texto = Console.ReadLine();

        char[] vetor = texto.ToCharArray();

        Console.WriteLine("Quantidade de elementos: " + vetor.Length);

        Console.Write("Vetor inverso: ");

        inverter(vetor);
    }
}
