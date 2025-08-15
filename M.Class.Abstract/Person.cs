namespace M.Class.Abstract;

internal abstract class Person(string name, int age, Gender gender)
{
    protected string Name { get; } = name;
    protected int Age { get; } = age;
    protected Gender Gender { get; } = gender;

    internal abstract string Introduce();
    internal abstract string Greet(string name);
}