namespace M.Class.Abstract;

internal class Faculty(string name, int age, Gender gender, string facultyName)
    : Person(name, age, gender)
{
    private string FacultyName { get; } = facultyName;

    internal override string Introduce() => $"Hello, my name is {Name}, I am {Age} years old, I am a {Gender}.";

    internal override string Greet(string someoneName) =>
        $"Hello {someoneName}, nice to meet you! "
        + $"I work at the {FacultyName}.";
}