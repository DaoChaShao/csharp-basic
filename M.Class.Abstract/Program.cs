namespace M.Class.Abstract;

using Bogus;
using System;

class Program
{
    static void Main(string[] args)
    {
        #region Initialise Random and Faker

        Random random = new Random();
        Faker faker = new Faker();

        #endregion

        #region OOP - Abstract Class

        int amountTeacher = random.Next(3, 6);
        Console.WriteLine($"The amount of teachers is {amountTeacher}.");
        Teacher[] teachers = new Teacher[amountTeacher];
        string someoneName = "Tom & Jerry";

        Helper helper = new Helper();

        for (int i = 0; i < amountTeacher; i++)
        {
            (int index, string faculty) = new Helper().FacultyNamePicker();

            Teacher teacher = new Teacher(
                faker.Name.FullName(),
                random.Next(24, 65),
                helper.GenderPicker(),
                faculty,
                helper.SubjectPicker(index),
                random.Next(3000, 10001)
            );
            teachers[i] = teacher;

            Console.WriteLine(teacher.Introduce());
            Console.WriteLine(teacher.Greet(someoneName));
        }

        Console.WriteLine(teachers);

        #endregion
    }
}