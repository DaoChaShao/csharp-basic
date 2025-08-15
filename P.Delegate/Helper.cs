namespace P.Delegate;

using System;

public class Helper
{
    internal string GreetInEnglish(string name) => $"Hello, {name}";
    internal string LeaveInEnglish(string name) => $"Goodbye, {name}";
    internal string GreetInChinese(string name) => $"你好, {name}";

    internal Option OptionPicker()
    {
        Option[] options = [Option.English, Option.Chinese];
        var index = new Random().Next(0, options.Length);
        return options[index];
    }

    internal void DelegateExecutor(string name, DelegateAgent agent)
    {
        Console.WriteLine(agent(name));
    }
}