using System;
using System.IO;

class Program
{

    static void lerMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);  // Obtém o número de linhas
        int colunas = matriz.GetLength(1); // Obtém o número de colunas

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            } // fim for j
        } // fim for i
    }

    static void mostrarMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write($"{matriz[i, j],3}| ");
            }
            Console.WriteLine();
        }
    }

    public static int[,] carregarMatriz(string caminhoArquivo)
    {
        string[] linhas = File.ReadAllLines(caminhoArquivo);
        int numLinhas = linhas.Length;
        int numColunas = linhas[0].Split(',').Length;

        int[,] matriz = new int[numLinhas, numColunas];

        for (int i = 0; i < numLinhas; i++)
        {
            string[] valores = linhas[i].Split(',');
            for (int j = 0; j < numColunas; j++)
            {
                matriz[i, j] = int.Parse(valores[j]);
            }
        }
        return matriz;
    }

    static int verificarOcorrencias(int[,] matriz, int valorX)
    {
        int contador = 0;
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        Console.WriteLine($"\nDetectando setores com o código de ocorrência {valorX}:");

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                // Verifica se a célula atual possui a ocorrência procurada
                if (matriz[i, j] == valorX)
                {
                    //?
                    contador++;
                    Console.WriteLine($" -> Ocorrência encontrada no Setor [{i}, {j}]");
                }
            }
        }

        return contador;
    }


    static void Main()
    {
        Console.Write("Digite o caminho do arquivo CSV (ex: ocorrencias.csv): ");
        string caminho = Console.ReadLine();

        // 1. Carregar a matriz do arquivo CSV
        int[,] mapa = carregarMatriz(caminho);

        Console.WriteLine("\n--- MATRIZ MAPA CARREGADA DO ARQUIVO CSV ---");
        // 2. Exibir a matriz utilizando a BibliotecaMatriz
        mostrarMatriz(mapa);

        Console.Write("\nDigite o código da ocorrência (X) que deseja verificar (ex: 1=Queimada): ");
        int codigoX = int.Parse(Console.ReadLine());

        // 3. Chamada da função dedicada para verificar e contar ocorrências
        int totalEncontrado = verificarOcorrencias(mapa, codigoX); // chame a função;

        // 4. Apresentação dos resultados
        Console.WriteLine($"\n[RESULTADO DA ANÁLISE]");
        Console.WriteLine($"Total de ocorrências do código {codigoX} encontradas na reserva: {totalEncontrado}");
    }
}