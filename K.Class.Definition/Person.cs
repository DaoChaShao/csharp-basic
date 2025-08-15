using Bogus.DataSets;

namespace K.Class.Definition;

internal class Person(string name, int age, Gender gender)
{
    private static int _personCount = 0;
    protected string Name { get; set; } = name;
    private int Age { get; set; } = age;
    private Gender Gender { get; set; } = gender;

    private readonly int _ = (_personCount++, 0).Item2;

    // Method I
    // internal string Introduce()
    // {
    //     return $"Hello, my name is {Name} and I am {Age} years old, and my gender is {Gender}.";
    // }

    // Method II
    internal virtual string Introduce() =>
        $"Hello, my name is {Name} and I am {Age} years old, and my gender is {Gender}.";

    internal static int GetPersonCount() => _personCount;
}