using System;

class Ex1002
{
    static void Main()
    {
       double R, A, n = 3.14159;
       R = double.Parse(Console.ReadLine());
       A = n * R * R;
       Console.WriteLine($"A={A:F4}");
    }
}