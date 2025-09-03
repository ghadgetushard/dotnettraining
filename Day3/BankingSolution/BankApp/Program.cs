using Banking;

Account acc = new Account();

acc.Balance = 77000;

acc.Withdraw(5000);
acc.Deposit(5000);

Console.WriteLine($"Account Balance : {acc.Balance}");

