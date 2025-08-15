namespace M.Class.Abstract;

internal class Helper
{
    internal Gender GenderPicker()
    {
        Gender[] genders =
        [
            Gender.Female,
            Gender.Male
        ];
        int index = new Random().Next(0, genders.Length);

        return genders[index];
    }

    internal (int, string) FacultyNamePicker()
    {
        string[] facultyNames =
        [
            "Faculty of Engineering",
            "Faculty of Medicine",
            "Faculty of Law",
            "Faculty of Economics",
            "Faculty of Social and Political Sciences",
            "Faculty of Cultural Sciences",
            "Faculty of Mathematics and Natural Sciences",
            "Faculty of Computer Science",
            "Faculty of Pharmacy",
            "Faculty of Psychology"
        ];
        int index = new Random().Next(0, facultyNames.Length);

        return (index, facultyNames[index]);
    }

    internal string SubjectPicker(int index)
    {
        string[] subjects =
        [
            "Engineer", // Faculty of Engineering
            "Doctor", // Faculty of Medicine
            "Lawyer", // Faculty of Law
            "Economist", // Faculty of Economics
            "Political Scientist", // Faculty of Social and Political Sciences
            "Cultural Specialist", // Faculty of Cultural Sciences
            "Scientist", // Faculty of Mathematics and Natural Sciences
            "Programmer", // Faculty of Computer Science
            "Pharmacist", // Faculty of Pharmacy
            "Psychologist" // Faculty of Psychology
        ];

        return subjects[index];
    }
}