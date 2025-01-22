namespace SOLID_Examples.LSP_Violation;

public class BankAccount
{
    protected double balance;
    public virtual void Deposit(double amount)
    {
        balance += amount;
    }
    public virtual void Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
        }
        else
        {
            throw new InvalidOperationException("Insufficient funds");
        }
    }
    public double GetBalance()
    {
        return balance;
    }
}