namespace L.Basic.Array;

using System;

public class Helper
{
    internal int RandomScoreGenerator(in int scoreMin, in int scoreMax)
    {
        Random random = new Random();
        return random.Next(scoreMin, scoreMax + 1);
    }

    internal void BubbleSort(in int[] array)
    {
        Console.WriteLine("Before sorting: " + string.Join(", ", array));

        for (int i = 0; i < array.Length - 1; i++)
        {
            // Set the flag to true to enter the loop
            bool swapped = false;

            // Perform bubble sort
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);

                    // Set the flag to true if a swap occurs
                    swapped = true;
                }
            }

            // If no swaps occurred, the array is sorted
            if (swapped)
            {
                Console.WriteLine("Array is sorted.");
                swapped = false;
            }
            else
            {
                Console.WriteLine("Array is already sorted.");
                break;
            }
        }

        Console.WriteLine("After sorting: " + string.Join(", ", array));
    }
}