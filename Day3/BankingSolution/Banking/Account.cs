namespace Banking;

public class Account
{
    public decimal Balance;
    public void withdraw(decimal amount)
    {
        // Implementation for withdrawing amount from the account
        if (amount > 0 && amount <= Balance)
        {
            decimal newBalance = Balance - (decimal)amount;
            if (newBalance < 10000)
            {
                underBalance(); //trigger event
            }
            Balance = newBalance;
            Console.WriteLine($"Withdrew {amount}. New balance is {Balance}");
        }
        // if (amount > Balance)
        // {
        //     Console.WriteLine("Insufficient funds");
        // }
        else
        {
            Balance -= (decimal)amount;
            Console.WriteLine($"Withdrew {amount}. New balance is {Balance}");
        }
    }

    public void deposit(decimal amount)
    {
        // Implementation for depositing amount into the account
        Balance += (decimal)amount;
        Console.WriteLine($"Deposited {amount}. New balance is {Balance}");
    }

    public decimal getBalance()
    {
        return Balance;

    }

    public event AccountOperation underBalance;


}