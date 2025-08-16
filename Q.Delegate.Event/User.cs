namespace Q.Delegate.Event;

internal class User(string userName, int userId, Gender gender)
{
    private string UserName { get; } = userName;
    private int UserId { get; } = userId;
    private Gender Gender { get; } = gender;

    internal string Introduce() => $"The user {UserName} has been created with ID {UserId}. I am a {Gender}.";

    // Declare a delegate event
    internal event EventAgent? OnLoad;

    // Define the method signature for the delegate event
    internal void LoadTrigger()
    {
        if (OnLoad != null)
        {
            foreach (var handler in OnLoad.GetInvocationList())
            {
                var loadMessage = ((EventAgent)handler)(UserName);
                Thread.Sleep(new Helper().DelaySetter());
                Console.WriteLine($"{loadMessage} Time consumed {new Helper().DelaySetter() / 1000} seconds.");
            }
        }
    }
}