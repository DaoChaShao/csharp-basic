namespace D.Basic.Calculation;

using System;
using Bogus;

class Program
{
    static void Main(string[] args)
    {
        #region FakeData

        var faker = new Faker("en");
        Console.WriteLine(faker.Name.FullName());

        #endregion

        #region Calculator

        Random random = new Random();
        var num = random.Next(1, 11);
        Console.WriteLine($"The random number is {num}.");

        var x = random.Next(1, 11);
        var y = random.Next(1, 11);
        Console.WriteLine($"X is {x}, and Y is {y}, and the sum is {x + y}.");
        Console.WriteLine($"X is {x}, and Y is {y}, and the difference is {x - y}.");
        Console.WriteLine($"X is {x}, and Y is {y}, and the product is {x * y}.");
        Console.WriteLine($"X is {x}, and Y is {y}, and the quotient is {x / y}.");

        #endregion
    }
}