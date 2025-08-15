namespace K.Class.Definition;

using Bogus;
using System;

class Program
{
    static void Main(string[] args)
    {
        #region Random number setting

        Random random = new Random();

        #endregion

        #region Name setting

        var faker = new Faker("en_US");
        string name = faker.Name.FullName();
        Console.WriteLine($"The fake name is {name}.");

        #endregion

        #region Gender setting

        // Method I: Initialise the Helper class
        Helper helper = new Helper();
        Gender gender = helper.GenderPicker();
        Console.WriteLine($"The random gender is {gender}");

        #endregion

        #region Age setting

        int age = random.Next(6, 24);
        Console.WriteLine($"The random age is {age}.");

        #endregion

        #region OOP

        // Method I
        Person personI = new Person(name, age, gender);
        string introI = personI.Introduce();
        Console.WriteLine(introI);

        // Method II
        Person personII;
        personII = new Person(name, age, gender);
        string introII = personII.Introduce();
        Console.WriteLine(introII);

        #endregion

        #region Create objects in a loop

        int amountPerson = random.Next(3, 6);
        Console.WriteLine($"The amount of people to create is {amountPerson}.");

        for (int i = 1; i <= amountPerson; i++)
        {
            // Set random gender
            // Method II: Use the Helper class directly
            Gender genderPerson = new Helper().GenderPicker();

            Person person = new Person(faker.Name.FullName(), random.Next(6, 24), genderPerson);
            Console.WriteLine($"Person {i}: {person.Introduce()}");
        }

        Console.WriteLine($"There are {Person.GetPersonCount()} people created in total.");

        #endregion

        #region Heritance using Student class

        int amountStudent = random.Next(3, 6);
        Console.WriteLine($"The amount of students to create is {amountStudent}.");

        for (int i = 0; i < amountStudent; i++)
        {
            Gender genderStudent = new Helper().GenderPicker();

            Student student = new Student(faker.Name.FullName(), random.Next(6, 24), genderStudent,
                random.Next(50, 100));
            Console.WriteLine($"Student {i + 1}: {student.Introduce()}");
            Console.WriteLine(student.Study());
        }

        Console.WriteLine($"There are {Person.GetPersonCount()} people created in total.");

        #endregion

        #region Heritance using Teacher class

        int amountTeacher = random.Next(3, 6);
        Console.WriteLine($"The amount of teachers to create is {amountTeacher}.");

        for (int i = 0; i < amountTeacher; i++)
        {
            Gender genderTeacher = new Helper().GenderPicker();

            Teacher teacher = new Teacher(faker.Name.FullName(), random.Next(20, 60), genderTeacher,
                random.Next(5000, 10000));
            Console.WriteLine($"Teacher {i + 1}: {teacher.Introduce()}");
            Console.WriteLine(teacher.Teach());
        }

        Console.WriteLine($"There are {Person.GetPersonCount()} people created in total.");

        #endregion
    }
}