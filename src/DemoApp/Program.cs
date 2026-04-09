using DemoApp;

Console.WriteLine($"2 + 3 = {MathOps.Add(2, 3)}");
Console.WriteLine($"10 - 3 = {MathOps.Subtract(10, 3)}");

namespace DemoApp
{
    public static class MathOps
    {
        public static int Add(int a, int b) => a + b;
    }
}
