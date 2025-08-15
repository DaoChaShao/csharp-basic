namespace N.Class.Interface;

internal class Teacher(
    string name,
    int age,
    Gender gender,
    string subject,
    bool isSing = false,
    bool isDance = false,
    bool isChinese = false,
    bool isEnglish = false
)
    : Person(name, age, gender), ISing, IDance, IChinese, IEnglish
{
    private string Subject { get; set; } = subject;

    internal override string Introduce() =>
        $"Hello, my name is {Name}, I am {Age} years old, I am a {Gender}."
        + $"I am a teacher of {Subject}.";

    public string Sing() => isSing ? $"{Name} can sing." : $"{Name} cannot sing.";
    public string Dance() => isDance ? $"{Name} can dance." : $"{Name} cannot dance.";
    public string SpeakChinese() => isChinese ? $"{Name} can speak Chinese." : $"{Name} cannot speak Chinese.";
    public string SpeakEnglish() => isEnglish ? $"{Name} can speak English." : $"{Name} cannot speak English.";
}