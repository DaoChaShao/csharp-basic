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

        int amount = random.Next(3, 6);
        Console.WriteLine($"The amount of people to create is {amount}.");

        for (int i = 1; i <= amount; i++)
        {
            // Set random gender
            // Method II: Use the Helper class directly
            Gender genderRandom = new Helper().GenderPicker();

            Person person = new Person(faker.Name.FullName(), random.Next(6, 24), genderRandom);
            Console.WriteLine($"Person {i}: {person.Introduce()}");
        }

        #endregion
    }
}