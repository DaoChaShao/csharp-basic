namespace K.Class.Definition;

internal class Student(string name, int age, Gender gender, float score)
    : Person(name, age, gender)
{
    private float Score { get; set; } = score;

    internal override string Introduce() => $"{base.Introduce()} And my score is {Score}.";
    internal string Study() => $"This is {Name.ToUpper()}, and I love studying.";
}