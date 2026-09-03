using System;
using BibliotecaMatriz;
class Program
{
    static void lerMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);
        //lendo a matriz
        for(int i=0; i < linhas; i++)
        {
             
            for(int j=0; j < cols; j++)
            {
                Console.Write($"[{i},{j}]:");
                matriz[i,j] = int.Parse(Console.ReadLine());
            }//fim for j
        }//fim for i
    }//fim funcao


    //mostrar matriz
    static void mostrarMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int cols = matriz.GetLength(1);
        //mostrar a matriz


    for (int i = 0; i < linhas; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{matriz[i, j],3}| ");
        }
        Console.WriteLine();
    }
    }
    static void Main()
    {
        int linhas;
        int cols;
        Console.Write("Qtde de linhas:");
        linhas = int.Parse(Console.ReadLine());
        Console.Write("Qtde de colunas:");
        cols = int.Parse(Console.ReadLine());
        int[,] matriz = new int[linhas,cols];
     
        Matriz.lerMatriz(matriz);
        Matriz.mostrarMatriz(matriz);
        Matriz.gerarMatriz(matriz);
        Matriz.mostrarMatriz(matriz);
       
    Console.ReadKey();//pausa
}
   
    }
