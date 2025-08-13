namespace J.ExceptionHandling;

using System;

class Program
{
    static void Main(string[] args)
    {
        #region Random number setting

        Random random = new Random();
        int dividend = random.Next(1, 11);
        int divisor = random.Next(0, 2);

        #endregion

        #region Normal Exception

        // try
        // {
        //     Console.WriteLine($"The result of {dividend} divided by {divisor} is {dividend / divisor}.");
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine(e);
        //     throw;
        // }
        // finally
        // {
        //     Console.WriteLine("Goodbye");
        // }

        #endregion

        #region Typed Exception

        try
        {
            Console.WriteLine($"The result of {dividend} divided by {divisor} is {dividend / divisor}.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        finally
        {
            Console.WriteLine("Goodbye");
        }

        #endregion
    }
}