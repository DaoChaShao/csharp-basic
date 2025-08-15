namespace P.Delegate;

using Bogus;
using System;

class Program
{
    static void Main(string[] args)
    {
        #region Initialisation

        var fEnglish = new Faker();
        var nameEnglish = fEnglish.Name.FirstName();
        var fChinese = new Faker("zh_CN");
        var nameChinese = fChinese.Name.FirstName();

        Helper helper = new Helper();

        DelegateAgent agent;

        #endregion;

        #region Delegate usage - switch

        if (helper.OptionPicker() == Option.English)
        {
            // Method I
            // agent = new DelegateAgent(helper.GreetInEnglish);
            // Method II
            agent = helper.GreetInEnglish;
            Console.WriteLine($"{agent.Invoke(nameEnglish)}");
        }
        else
        {
            // Method I
            // agent = new DelegateAgent(helper.GreetInChinese);
            // Method II
            agent = helper.GreetInChinese;
            Console.WriteLine($"{agent.Invoke(nameChinese)}");
        }

        #endregion

        #region Delegate usage - Callback

        if (helper.OptionPicker() == Option.English)
        {
            helper.DelegateExecutor(nameEnglish, helper.GreetInEnglish);
        }
        else
        {
            helper.DelegateExecutor(nameChinese, helper.GreetInChinese);
        }

        #endregion

        #region Delegate usage - Multicast

        DelegateAgent agentGreet = helper.GreetInEnglish;
        DelegateAgent agentLeave = helper.LeaveInEnglish;
        DelegateAgent agentMeet = agentGreet + agentLeave;

        foreach (Delegate da in agentMeet.GetInvocationList())
        {
            Console.WriteLine(da.DynamicInvoke(nameEnglish));
        }

        #endregion
    }
}