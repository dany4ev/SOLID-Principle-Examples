namespace SOLID_Examples.LSP_Applied;

public class FixedTermDepositAccount : BankAccount
{
    private bool termEnded = false; // simplification for the example
    public override void Withdraw(double amount)
    {
        if (!termEnded)
        {
            Console.WriteLine("Cannot withdraw from a fixed term deposit account until term ends");
        }
        else if (balance >= amount)
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