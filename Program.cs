using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Addition: 5 + 3 = " + Add(5, 3));
        Console.WriteLine("Subtraction: 10 - 4 = " + Subtract(10, 4));
        Console.WriteLine("Multiplication: 6 * 7 = " + Multiply(6, 7));
        Console.WriteLine("Division: 20 / 5 = " + Divide(20, 5));
    }

    static int Add(int a, int b) => a + b;
    static int Subtract(int a, int b) => a - b;
    static int Multiply(int a, int b) => a * b;
    static double Divide(double a, double b) => a / b;
}
