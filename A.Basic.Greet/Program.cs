namespace A.Basic.Greet;

using System;

class Program
{
    static void Main(string[] args)
    {
        #region hello world

        Console.WriteLine("Hello, World!");

        #endregion

        #region variables

        var greeting = "Hello, World!";
        Console.WriteLine(greeting);

        #endregion

        #region string concatenation

        var word = "world";
        Console.WriteLine($"Hello, {word}!");

        #endregion
    }
}