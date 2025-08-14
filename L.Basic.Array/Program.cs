using System.Security.Cryptography;

namespace L.Basic.Array;

using System;

class Program
{
    static void Main(string[] args)
    {
        #region Random number setting

        Random random = new Random();

        #endregion

        #region Array

        // Method I: Old-fashioned
        // string[] genders = new[] { "Male", "Female" };

        // Method II: C# 12
        string[] genders = ["Female", "Male"];
        int genderIndex = random.Next(0, genders.Length);
        Console.WriteLine($"The random gender number is {genderIndex}");
        Console.WriteLine($"The random gender is {genders[genderIndex]}");

        #endregion

        #region Iterate over array using for

        for (int i = 0; i < genders.Length; i++)
        {
            Console.WriteLine($"The current gender in the genders array is {genders[i]}");
        }

        #endregion

        #region Iterate over array using foreach

        foreach (var gender in genders)
        {
            Console.WriteLine($"The current gender in the genders array is {gender}");
        }

        #endregion

        #region Calculate average using array

        int amountOfStudents = 20;
        int[] scores = new int[amountOfStudents];
        int scoreMin = 0;
        int scoreMax = 100;
        int scoreSum = 0;

        for (int i = 0; i < amountOfStudents; i++)
        {
            int score = new Helper().RandomScoreGenerator(scoreMin, scoreMax);
            scores[i] = score;
            Console.WriteLine($"The score of student {i + 1} is {score}");
            scoreSum += score;
        }

        Console.WriteLine($"The scores are: {string.Join(", ", scores)}");
        Console.WriteLine($"The scores sum is: {scoreSum}");
        Console.WriteLine($"The scores average is: {(scoreSum / (double)amountOfStudents):F2}");

        #endregion

        #region 2 Dimensional Array

        int group = 3;
        int studentsPerGroup = 10;
        int gradeMin = 0;
        int gradeMax = 100;

        int[,] students = new int[group, studentsPerGroup];

        for (int i = 0; i < group; i++)
        {
            for (int j = 0; j < studentsPerGroup; j++)
            {
                students[i, j] = new Helper().RandomScoreGenerator(gradeMin, gradeMax);
                Console.WriteLine($"The score of student {j + 1} in group {i + 1} is {students[i, j]}");
            }
        }

        int groupIndex = random.Next(0, group);
        Console.WriteLine($"The random group number is {groupIndex}");
        int studentIndex = random.Next(0, studentsPerGroup);
        Console.WriteLine($"The random student number is {studentIndex}");

        Console.WriteLine($"The type of the students array is {students.GetType()}");
        Console.WriteLine($"The number of dimensions of the students array is {students.Rank}");

        Console.WriteLine($"The random student number is {students[groupIndex, studentIndex]}");

        #endregion

        #region Jagged Array

        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = [1, 2, 3];
        jaggedArray[1] = [4, 5, 6, 7];
        jaggedArray[2] = [8, 9];

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.WriteLine($"The value at jaggedArray[{i}][{j}] is {jaggedArray[i][j]}");
            }
        }

        Console.WriteLine($"The type of the jaggedArray is {jaggedArray.GetType()}");

        #endregion

        #region Sorting an array with Bubble Sort

        int[] numsForBubbleSort = [5, 3, 8, 4, 2];
        Console.WriteLine("Before sorting: " + string.Join(", ", numsForBubbleSort));

        for (int i = 0; i < numsForBubbleSort.Length - 1; i++)
        {
            for (int j = 0; j < numsForBubbleSort.Length - 1 - i; j++)
            {
                if (numsForBubbleSort[j] > numsForBubbleSort[j + 1])
                {
                    // Swap the elements: Method I: Using a temporary variable
                    // int temp = numsForBubbleSort[j];
                    // numsForBubbleSort[j] = numsForBubbleSort[j + 1];
                    // numsForBubbleSort[j + 1] = temp;

                    // Swap the elements: Method II: Using tuple deconstruction (C# 7.0 and later)
                    (numsForBubbleSort[j], numsForBubbleSort[j + 1]) = (numsForBubbleSort[j + 1], numsForBubbleSort[j]);
                }
            }
        }

        Console.WriteLine("After sorting: " + string.Join(", ", numsForBubbleSort));

        #endregion

        #region Sorting an array with Bubble Sort using Helper class

        int[] nums = [6, 4, 9, 5, 3];
        // int[] nums = [1, 2, 3, 4, 5];
        // int[] nums = [2, 1, 4, 3, 5];
        new Helper().BubbleSort(nums);

        #endregion
    }
}