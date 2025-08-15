namespace O.Generic;

public class Helper
{
    internal T StoreNum<T>(T value)
    {
        T[] array = new T[1];
        array[0] = value;
        return array[0];
    }

    // Method I
    internal T Sum<T>(T x, T y)
    {
        dynamic? dx = x;
        dynamic? dy = y;
        return dx + dy;
    }

    // Method II
    internal dynamic Sum(dynamic x, dynamic y)
    {
        return x + y;
    }
}