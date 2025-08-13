namespace H.Basic.Enum;

using System;

enum Gender
{
    Male,
    Female,
}

class Program
{
    static void Main(string[] args)
    {
        #region Normal Enum Usage

        Console.WriteLine($"The gender is {Gender.Male}");
        Console.WriteLine($"The gender is {Gender.Female}");

        #endregion

        #region Convert Enum

        int valueMale = (int)Gender.Male;
        int valueFemale = (int)Gender.Female;
        Console.WriteLine($"The value of male is {valueMale}");
        Console.WriteLine($"The value of female is {valueFemale}");

        #endregion
    }
}