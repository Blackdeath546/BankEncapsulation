namespace BankEncapsulation;

class BankAccount
{
    private double _balance = 0;

    public void Deposit(double amount)
    {
        _balance += amount;
    }

    public void GetBalance()
    {
        Console.WriteLine($"The balance is {_balance}");
    }

}

