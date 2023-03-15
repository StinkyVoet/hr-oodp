public class BankAccount
{
    private double _balance;

    public BankAccount(double balance)
    {
        _balance = balance;
    }

    public double ReadBalance() => _balance;

    public void Deposit(double value) {
        if (value > 0) _balance += value;
    }

    public double Withdraw(double value)
    {
        if (!SufficientBalance(value) || value < 0) return 0;

        _balance -= value;
        return value;
    }

    private bool SufficientBalance(double value) => _balance >= value;
}