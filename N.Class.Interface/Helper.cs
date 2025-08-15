namespace N.Class.Interface;

public class Helper
{
    internal Gender GenderPicker()
    {
        Gender[] genders = [Gender.Female, Gender.Male];
        var index = new Random().Next(0, 2);
        return genders[index];
    }

    internal string SubjectPicker()
    {
        string[] subjects = ["Math", "English", "Chinese", "Biology", "Chemistry", "Physics"];
        var index = new Random().Next(0, subjects.Length);
        return subjects[index];
    }

    internal bool BoolPicker()
    {
        bool[] booleans = [true, false];
        var index = new Random().Next(0, 2);
        return booleans[index];
    }
}