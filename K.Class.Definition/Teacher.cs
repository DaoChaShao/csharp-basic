namespace K.Class.Definition;

internal class Teacher(string name, int age, Gender gender, float salary) :
    Person(name, age, gender)
{
    private readonly string _age = age.ToString();
    private float Salary { get; set; } = salary;

    internal override string Introduce() => $"{base.Introduce()} And my salary is {Salary}.";
    internal string Teach() => $"I am {_age} years old, and I love working.";
}