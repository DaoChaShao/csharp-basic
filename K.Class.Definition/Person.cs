namespace K.Class.Definition;

internal class Person(string name, int age, Gender gender)
{
    private string Name { get; set; } = name;
    private int Age { get; set; } = age;
    private Gender Gender { get; set; } = gender;


    internal string Introduce()
    {
        return $"Hello, my name is {Name} and I am {Age} years old, and my gender is {Gender}.";
    }
}