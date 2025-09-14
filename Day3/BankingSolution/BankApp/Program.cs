using Banking;
using Banking.Handlers;


Account account = new Account();

// Register event handlers with events before any operation takes place.
account.underBalance += AccountListener.BlockAccount;
account.underBalance += AccountListener.sendEmail;

account.Balance = 10000;

// account.deposit(15000);
account.withdraw(9000);
// Console.WriteLine($"Initial Balance: {account.getBalance()}");

// Console.WriteLine($"Final Balance: {account.getBalance()}");

// Direct calls to AccountListener methods
// AccountListener.sendEmail();
// AccountListener.BlockAccount();

// Indirect call
// AccountOperation accountOperations = new AccountOperation(AccountListener.BlockAccount);
// accountOperations();
