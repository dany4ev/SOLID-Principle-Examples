namespace SOLID_Examples.LSP_Violation;

public class FixedTermDepositAccount : BankAccount
{
    public override void Withdraw(double amount)
    {
        throw new InvalidOperationException("Cannot withdraw from a fixed term deposit account until term ends");
    }
}