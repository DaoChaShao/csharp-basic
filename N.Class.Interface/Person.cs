namespace N.Class.Interface;

internal abstract class Person(string name, int age, Gender gender)
{
    protected string Name { get; set; } = name;
    protected int Age { get; set; } = age;
    protected Gender Gender { get; set; } = gender;

    internal abstract string Introduce();
}