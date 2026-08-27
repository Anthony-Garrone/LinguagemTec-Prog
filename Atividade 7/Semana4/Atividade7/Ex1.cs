using System;

class Ex1
{ 
    static String decodificar(String codificada)
    {
    char[] decodificada = new char[codificada.Length];
    int j = 0;
        for(int i = 0; i < codificada.Length; i++){
            if(codificada[i] != 'p')
        {
            decodificada[j] = codificada[i];
            j++;
        }
            else if(i != 0 && i !=codificada.Length-1 && codificada[i+1] == 'p' && codificada[i-1] == 'p')
        {
                decodificada[j] = codificada[i];
                j++;
        }
    }
    // implementar
    return new String(decodificada);
    }
    static void Main()
    {
        String codificada;
        Console.Write("Entre com a frase codificada: ");
        codificada = Console.ReadLine();
        Console.WriteLine(decodificar(codificada));
        // chamar funcao e apresentar decodificada    
    }
}