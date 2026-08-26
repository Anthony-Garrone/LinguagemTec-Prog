using System;

class Ex9{
    static char[] GerarComplementar(char[] DNA)
    {
        char[] complementar = new char[DNA.Length];

        for(int i = 0; i < DNA.Length; i++)
        {
            if(DNA[i] == 'A')
                complementar[i] = 'T';
            else if(DNA[i] == 'T')
                 complementar[i] = 'A';
            else if(DNA[i] == 'C')
                 complementar[i] = 'G';
            else if(DNA[i] == 'G')
                 complementar[i] = 'C';
        }
        return complementar;
    }
    static void Main(){
        Console.Write("Digite a fita de DNA: ");
        string dna = Console.ReadLine().ToUpper();

        char[] DNA = dna.ToCharArray();

        char[] complementar = GerarComplementar(DNA);

        string fitaComplementar = new string(complementar);

        Console.WriteLine("Fita complementar: "+fitaComplementar);
    }
}