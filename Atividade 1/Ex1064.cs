using System;

class Ex1064
{
    static void Main()
    {
        double num, soma = 0, c = 0;
        for(int i = 0; i < 6; i++)
        {
            num = double.Parse(Console.ReadLine());
            if(num > 0)
            {
                soma += num;
                c++;
            }
        }
        Console.WriteLine($"{c} valores positivos");
        Console.WriteLine($"{(soma / c):F1}");
    }
}