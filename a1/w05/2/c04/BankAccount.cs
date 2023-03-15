public class BankAccount
{
    private double _balance;
    protected int YearsPassed = 0;
    protected double InterestRate;

    public BankAccount(double balance, double interestRate)
    {
        _balance = balance;
        InterestRate = interestRate;
    }

    public double ReadBalance() => _balance;

    public void Deposit(double value) {
        if (value > 0) _balance += value;
    }

    public virtual double Withdraw(double value)
    {
        if (!SufficientBalance(value) || value < 0) return 0;

        _balance -= value;
        return value;
    }

    private bool SufficientBalance(double value) => _balance >= value;

    public virtual void NextYear() => ApplyInterest();

    protected void ApplyInterest() => _balance *= 1 + InterestRate;
}