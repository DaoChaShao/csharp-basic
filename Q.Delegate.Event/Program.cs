namespace Q.Delegate.Event;

using Bogus;
using System;

class Program
{
    static void Main(string[] args)
    {
        #region Initialisation

        var faker = new Faker();
        var helper = new Helper();

        var loader = new Loader();
        var users = new List<User>();
        var userAmount = new Random().Next(3, 6);
        Console.WriteLine($"The amount of users to be created is {userAmount}.");
        for (var i = 0; i < userAmount; i++)
        {
            var user = new User(
                userName: faker.Name.FirstName(),
                userId: faker.Random.Int(1, 1000),
                helper.GenderPicker()
            );
            users.Add(user);
        }

        foreach (var user in users)
        {
            Console.WriteLine($"{user.Introduce()}");
        }

        #endregion

        #region Event Agent

        foreach (var user in users)
        {
            user.OnLoad += loader.LoadFiles;
            user.OnLoad += loader.LoadMaps;
            user.OnLoad += loader.LoadSkins;
        }

        foreach (var user in users)
        {
            user.LoadTrigger();
        }

        #endregion
    }
}