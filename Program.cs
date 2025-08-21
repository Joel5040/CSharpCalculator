using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Division: 20 / 5 = " + Divide(20, 5));
        Console.WriteLine("Subtraction: 10 - 4 = " + Subtract(10, 4));
        Console.WriteLine("Addition: 5 + 3 = " + Add(5, 3));
    }

    static double Divide(double a, double b) => a / b;
    static int Subtract(int a, int b) => a - b;
    static int Add(int a, int b) => a + b;
}
