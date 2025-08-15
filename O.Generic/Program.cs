namespace O.Generic;

using System;

class Program
{
    static void Main(string[] args)
    {
        #region Initialisation

        Helper helper = new Helper();
        Random random = new Random();

        #endregion

        #region StoreNum with int

        int num = random.Next(1, 10);
        int intNum = helper.StoreNum(num);
        Console.WriteLine($"Stored num is {intNum}, and its type is {intNum.GetType()}");

        #endregion

        #region StoreNum with double

        double doubleNum = random.Next(1, 10) + random.NextDouble();
        doubleNum = helper.StoreNum(doubleNum);
        Console.WriteLine($"Stored num is {doubleNum:F2}, and its type is {doubleNum.GetType()}");

        #endregion

        #region StoreNum with string

        string stringNum = random.Next(1, 10).ToString();
        stringNum = helper.StoreNum(stringNum);
        Console.WriteLine($"Stored num is {stringNum}, and its type is {stringNum.GetType()}");

        #endregion

        #region Calculate Method I

        var result = helper.Sum(intNum, doubleNum);
        Console.WriteLine($"The result using Method I is {result:F2}");

        #endregion

        #region Calculate Method II

        var outcome = helper.Sum(intNum, doubleNum);
        Console.WriteLine($"The outcome using Method II is {outcome:F2}");

        #endregion

        #region Constraint

        var constraintResult = helper.Sum(intNum, stringNum);
        Console.WriteLine(constraintResult);

        #endregion
    }
}