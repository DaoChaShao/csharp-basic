namespace M.Class.Abstract;

internal class Teacher(string name, int age, Gender gender, string facultyName, string profession, int salary)
    : Faculty(name, age, gender, facultyName)
{
    private string Profession { get; } = profession;
    private int Salary { get; } = salary;

    internal override string Introduce() => $"{base.Introduce()} My salary is {Salary} per month.";

    internal override string Greet(string someoneName) =>
        $"{base.Greet(someoneName)} My students will become {Profession}";
}