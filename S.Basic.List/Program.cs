namespace S.Basic.List;

using Bogus;
using System;

class Program
{
    static void Main(string[] args)
    {
        #region Initialisation

        var faker = new Faker();
        var random = new Random();

        #endregion

        #region List - Create

        var names = new List<string>();
        var amount = random.Next(5, 11);

        for (var i = 0; i < amount; i++)
        {
            var name = faker.Name.FirstName();
            if (!names.Contains(name))
            {
                names.Add(name);
            }
        }

        Console.WriteLine($"The list contains {names.Count} unique names.");

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        #endregion

        #region List - Read

        var searchName = "Alf";
        var message = names.Contains(searchName)
            ? $"The name '{searchName}' has been found in the list."
            : $"The name '{searchName}' was not found in the list.";
        Console.WriteLine(message);

        #endregion

        #region List - Update

        var indexReplace = random.Next(0, names.Count);
        var newName = faker.Name.FirstName();

        names[indexReplace] = newName;
        Console.WriteLine($"The name at index {indexReplace} has been replaced with '{newName}'.");

        #endregion

        #region List - Delete

        var deletedName = "Ron";
        if (names.Contains(deletedName))
        {
            names.Remove(deletedName);
            Console.WriteLine($"The name '{deletedName}' has been removed from the list.");
        }
        else
        {
            Console.WriteLine($"The name '{deletedName}' was not found in the list.");
        }

        Console.WriteLine($"The list now contains {names.Count} names after first deletion.");

        var indexDelete = random.Next(0, names.Count);
        names.RemoveAt(random.Next(0, names.Count));
        Console.WriteLine($"The name at index {indexDelete} has been removed from the list.");
        Console.WriteLine($"The list contains {names.Count} names after second deletion.");

        #endregion

        #region List - Sort

        names.Sort();

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        #endregion
    }
}