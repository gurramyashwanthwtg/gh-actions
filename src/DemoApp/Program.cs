using DemoApp;

Console.WriteLine($"2 + 3 = {MathOps.Add(2, 3)}");
Console.WriteLine($"10 - 3 = {MathOps.Subtract(10, 3)}");
Console.WriteLine($"4 * 5 = {MathOps.Multiply(4, 5)}");

namespace DemoApp
{
    public static class MathOps
    {
        public static int Add(int a, int b) => a + b;

        public static int Subtract(int a, int b) => a - b;

        public static int Multiply(int a, int b) => a * b;
    }
}
