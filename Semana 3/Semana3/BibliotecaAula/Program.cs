using System;
using BibliotecaFuncoes;

class Program
{
    
    static void Main()
    {
        int[] meuArray = new int[10];
        Biblioteca.lerVetor(meuArray);
        Biblioteca.mostrarVetor(meuArray);
        Console.ReadKey();//pausa
    }
}