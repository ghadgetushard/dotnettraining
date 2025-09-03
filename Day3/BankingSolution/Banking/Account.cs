namespace Banking;

public class Account
{
    // private decimal balance;

    // public decimal Balance
    // {
    //     get { return balance; }

    //     private set { balance = value; }
    // }

    // Auto Property : always public
    public decimal Balance { get; set; }

    public void Withdraw(decimal amount)
    {
        // Logic to Withdraw money
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
        }
    }

    public void Deposit(decimal amount)
    {
        // Logic to Deposit money
        if (amount > 0)
        {
            Balance += amount;
        }
    }
}
