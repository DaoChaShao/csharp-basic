using System.Collections.Immutable;

namespace T.Basic.Dictionary;

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

        #region Dictionary - Create

        var people = new Dictionary<string, Gender>
        {
            { "Tom", Gender.Male },
            { "Jerry", Gender.Female },
            { "Jack", Gender.Male },
            { "Rose", Gender.Female },
            { "Josh", Gender.Male }
        };


        Console.WriteLine($"The dictionary contains {people.Count} unique entries.");

        foreach (var keyValuePair in people)
        {
            Console.WriteLine($"Name: {keyValuePair.Key}, Gender: {keyValuePair.Value}");
        }

        #endregion

        #region Dictionary - Read

        var index = new Random().Next(0, people.Count);
        var nameList = people.Keys.ToList();
        var searchName = Helper.NamePicker(nameList[index]);
        var message = people.TryGetValue(searchName, out var genderValue)
            ? $"The name '{searchName}' has been found in the dictionary with '{genderValue}'"
            : $"The name '{searchName}' was not found in the dictionary.";
        Console.WriteLine(message);

        #endregion

        #region Dictionary - Update

        var indexUpdate = random.Next(0, people.Count);
        var nameUpdate = nameList[indexUpdate];
        people[nameUpdate] = Gender.Other;
        Console.WriteLine($"{nameUpdate}'s gender has been updated to {people[nameUpdate]}.");

        foreach (var keyValuePair in people)
        {
            Console.WriteLine($"Name: {keyValuePair.Key}, Gender: {keyValuePair.Value}");
        }

        Console.WriteLine($"The dictionary now contains {people.Count} entries after the update.");

        #endregion

        #region Dictionary - Delete

        var indexDelete = random.Next(0, people.Count);
        var nameDelete = nameList[indexDelete];
        people.Remove(nameDelete);

        foreach (var keyValuePair in people)
        {
            Console.WriteLine($"Name: {keyValuePair.Key}, Gender: {keyValuePair.Value}");
        }

        Console.WriteLine($"The dictionary contains {people.Count} entries after the delete.");

        #endregion

        #region Dictionary - Sort

        people.OrderBy(keyValuePair => keyValuePair.Key)
            .ToList()
            .ForEach(keyValuePair => Console.WriteLine($"Name: {keyValuePair.Key}, Gender: {keyValuePair.Value}"));

        #endregion
    }
}