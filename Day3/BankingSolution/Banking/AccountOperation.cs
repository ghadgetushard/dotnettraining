using Banking;

//what is the purpose of this delegate? 
//to define delegate and events for account operations

public delegate void AccountOperation();

// public class AccountOperations
// {
//     public event AccountOperation OnDeposit;
//     public event AccountOperation OnWithdraw;

//     public void Deposit(decimal amount)
//     {
//         OnDeposit?.Invoke(amount);
//     }

//     public void Withdraw(decimal amount)
//     {
//         OnWithdraw?.Invoke(amount);
//     }
// }