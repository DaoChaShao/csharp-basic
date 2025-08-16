namespace R.Operator.Overload;

using System;

class Program
{
    static void Main(string[] args)
    {
        #region Initialisation

        var random = new Random();

        #endregion

        #region Box operator overload

        var boxLeft = new Box(random.Next(1, 10), random.Next(1, 10), random.Next(1, 10));
        var boxRight = new Box(random.Next(1, 10), random.Next(1, 10), random.Next(1, 10));
        var box = boxLeft + boxRight;

        Console.WriteLine($"Box Left: {boxLeft}");
        Console.WriteLine($"Box Right: {boxRight}");
        Console.WriteLine($"Box: {box}");

        #endregion
    }
}