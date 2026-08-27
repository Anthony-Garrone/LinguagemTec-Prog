using System;
using BibliotecaFuncoes;

class Ex2
{
    static int contarImpares(int[] vetor)
    {
        int contadorImpares = 0;
        // percorrer o vetor e contar ímpares
        // retornar
        for(int i=0; i < vetor.Length; i++){
            if(vetor[i] % 2 != 0)
                contadorImpares++;
        }// fim for
        return contadorImpares;
    }
    static void Main()
    {
        int n, qtdImpares;
        Console.Write("Tamanho do vetor:");
        n = int.Parse(Console.ReadLine());
        int[] meuArray = new int[n];
        Biblioteca.gerarVetor(meuArray);
        Biblioteca.mostrarVetor(meuArray);
        qtdImpares = contarImpares(meuArray);// chamada da função
        Console.WriteLine("\nQuantidade de ímpares:"+qtdImpares);
        Console.ReadKey();

    }
}