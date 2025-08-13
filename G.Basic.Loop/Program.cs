namespace G.Basic.Loop;

using System;

class Program
{
    static void Main(string[] args)
    {
        #region Loop using While

        while (true)
        {
            Console.WriteLine("Welcome to the system!");
            Console.WriteLine("Enter 0 to exit the system!");

            var input = Console.ReadLine();
            if (input == "0")
            {
                Console.WriteLine("You exit the system!");
                break;
            }
        }

        Console.WriteLine("Thank you for using the system!");

        #endregion

        #region Random Number Setting

        Random random = new Random();

        #endregion

        #region Loop using do while

        uint count = 1;
        int maxCount = random.Next(3, 6);
        Console.WriteLine($"The maximum count is: {maxCount}");

        do
        {
            Console.WriteLine($"The current count is: {count}");
            count++;
            Console.WriteLine($"The count after increment is: {count}");
        } while (count < maxCount);

        #endregion

        #region Loop using for

        uint startNum = 1;
        int round = random.Next(3, 6);
        Console.WriteLine($"The round number is: {round}");

        for (int i = 1; i <= round; i++)
        {
            startNum++;
            Console.WriteLine($"current count is: {startNum} in the count round {i}.");
        }

        #endregion

        #region Loop using foreach

        int maxRange = 5;
        var numbers = Enumerable.Range(1, maxRange);
        Console.WriteLine($"The max range is: {maxRange}");
        Console.WriteLine(numbers);

        foreach (var number in numbers)
        {
            Console.WriteLine($"The number is: {number}");
        }

        #endregion
    }
}