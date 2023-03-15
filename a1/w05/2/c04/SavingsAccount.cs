public class SavingsAccount : BankAccount
{
    private bool _locked = true;

    public SavingsAccount(double balance, double interestRate) : base(balance, interestRate)
    {
    }

    public override double Withdraw(double value)
    {
        return _locked ? 0 : base.Withdraw(value);
    }

    public override void NextYear()
    {
        YearsPassed++;
        if (YearsPassed < 5) ApplyInterest();
        else _locked = false;
    }
}