namespace Q.Delegate.Event;

using System;

internal class Helper
{
    internal Gender GenderPicker()
    {
        Gender[] genders = [Gender.Female, Gender.Male];
        var index = new Random().Next(genders.Length);
        return genders[index];
    }

    internal int DelaySetter()
    {
        return new Random().Next(1, 4) * 1000;
    }
}