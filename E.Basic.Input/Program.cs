namespace E.Basic.Input;

using System;

class Program
{
    static void Main(string[] args)
    {
        #region Input with any prompt

        var input = Console.ReadLine();
        Console.WriteLine($"You entered: {input}");

        #endregion

        #region Input without none prompt

        var enteredText = Console.ReadLine()!;
        Console.WriteLine($"You entered: {enteredText}");

        #endregion

        #region Input number

        var number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"You entered: {number}");

        #endregion
    }
}