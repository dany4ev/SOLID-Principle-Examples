namespace SOLID_Examples.LSP_Applied;

public abstract class BankAccount
{
    protected double balance;
    public virtual void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposit: {amount}, Total Amount: {balance}");
    }
    public abstract void Withdraw(double amount);
    public double GetBalance()
    {
        return balance;
    }
}