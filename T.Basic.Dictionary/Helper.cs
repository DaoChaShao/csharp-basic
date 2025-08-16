namespace T.Basic.Dictionary;

public class Helper
{
    internal static Gender GenderPicker()
    {
        var random = new Random();
        var genders = new List<Gender> { Gender.Female, Gender.Male };
        var index = random.Next(0, genders.Count);
        return genders[index];
    }

    internal static string NamePicker(string listName)
    {
        var names = new List<string> { "Alf", listName };
        var index = new Random().Next(0, names.Count);
        return names[index];
    }
}