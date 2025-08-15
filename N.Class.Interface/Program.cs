namespace N.Class.Interface;

using Bogus;
using System;

class Program
{
    static void Main(string[] args)
    {
        #region Initialisation

        Random random = new Random();
        var faker = new Faker();

        #endregion

        #region OOP

        var amountTeacher = random.Next(3, 6);
        Console.WriteLine($"The school has {amountTeacher} teachers.");
        Teacher[] teachers = new Teacher[amountTeacher];

        for (int i = 0; i < amountTeacher; i++)
        {
            var teacher = new Teacher(
                faker.Name.FullName(),
                random.Next(25, 65),
                new Helper().GenderPicker(),
                new Helper().SubjectPicker(),
                new Helper().BoolPicker(),
                new Helper().BoolPicker(),
                new Helper().BoolPicker(),
                new Helper().BoolPicker()
            );
            teachers[i] = teacher;
            Console.WriteLine(teacher.Introduce());
            Console.WriteLine(teacher.Sing());
            Console.WriteLine(teacher.Dance());
            Console.WriteLine(teacher.SpeakChinese());
            Console.WriteLine(teacher.SpeakEnglish());
        }

        Console.WriteLine($"The school has {teachers.Length} teachers.");

        #endregion
    }
}