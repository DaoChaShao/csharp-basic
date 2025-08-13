namespace b_data_type;

class Program
{
    static void Main(string[] args)
    {
        #region Integer

        int numInt = -9527;
        Console.WriteLine($"The number of INT is {numInt}.");

        uint numUint = 9527u;
        Console.WriteLine($"The number of UINT is {numUint}.");

        #endregion

        #region Float

        float numFloat = 3.14159f;
        Console.WriteLine($"The number of FLOAT is {numFloat}.");
        double numDouble = 3.14159;
        Console.WriteLine($"The number of DOUBLE is {numDouble}.");

        #endregion

        #region Character

        char letter = 'Y';
        Console.WriteLine($"The character is {letter}.");

        #endregion

        #region Bool

        bool boolean = true;
        Console.WriteLine($"The status is {boolean}.");

        #endregion
    }
}