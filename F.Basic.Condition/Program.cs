namespace F.Basic.Condition;

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
        #region Random number setting

        Random random = new Random();

        #endregion

        #region Condition with if

        var genderNum = random.Next(0, 3);
        Console.WriteLine($"The gender number is {genderNum} ");

        if (genderNum == 0)
        {
            Console.WriteLine($"The gender you selected is {Gender.Female}");
        }
        else
        {
            Console.WriteLine($"The gender you selected is {Gender.Male}");
        }

        #endregion

        #region Ternary Operator

        Console.WriteLine($"The gender you selected is {(genderNum == 0 ? Gender.Female : Gender.Male)}");

        #endregion

        #region Condition with switch

        var weekNum = random.Next(1, 9);
        Console.WriteLine($"The week number is {weekNum}");

        switch (weekNum)
        {
            case 1:
                Console.WriteLine("It's Monday");
                break;
            case 2:
                Console.WriteLine("It's Tuesday");
                break;
            case 3:
                Console.WriteLine("It's Wednesday");
                break;
            case 4:
                Console.WriteLine("It's Thursday");
                break;
            case 5:
                Console.WriteLine("It's Friday");
                break;
            case 6:
                Console.WriteLine("It's Saturday");
                break;
            case 7:
                Console.WriteLine("It's Sunday");
                break;
            default:
                Console.WriteLine("There is no such day in the week");
                break;
        }

        #endregion
    }
}