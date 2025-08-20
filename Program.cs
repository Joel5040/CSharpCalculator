using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Addition: 5 + 3 = " + Add(5, 3));
        Console.WriteLine("Subtraction: 10 - 4 = " + Subtract(10, 4));
    }

    static int Add(int a, int b) => a + b;
    static int Subtract(int a, int b) => a - b;
}
