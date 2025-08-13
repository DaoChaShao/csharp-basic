namespace I.Function;

using System;

class Program
{
    static void Main(string[] args)
    {
        #region Function without parameters

        Greet();

        #endregion

        #region Random number setting

        Random random = new Random();
        int x = random.Next(1, 11);
        int y = random.Next(1, 11);

        #endregion

        #region Function without return value

        Add(x, y);

        #endregion

        #region Function with return value

        int result = Sum(x, y);
        Console.WriteLine($"The sum of {x} and {y} is {result}.");

        #endregion
    }

    private static void Greet()
    {
        Console.WriteLine("Hello World!");
    }

    private static void Add(int m, int n)
    {
        int result = m + n;
        Console.WriteLine($"The result of {m} plus {n} is {result}.");
    }

    private static int Sum(int m, int n)
    {
        return m + n;
    }
}