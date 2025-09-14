namespace Banking.Handlers;

//utility class
//helper class
public static class AccountListener
{
    public static void BlockAccount()
    {
        Console.WriteLine($"Block account event triggered.");
    }

    public static void sendEmail()
    {
        Console.WriteLine($"Send Email account event triggered.");
    }
}
