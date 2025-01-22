namespace SOLID_Examples.LSP_Applied;

public class RegularAccount : BankAccount
{
    public override void Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine($"Withdraw: {amount}, Balance: {balance}");
        }
        else
        {
            Console.WriteLine($"Trying to Withdraw: {amount}, Insufficient Funds, Available Funds: {balance}");
        }
    }
}