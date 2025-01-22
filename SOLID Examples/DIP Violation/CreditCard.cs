namespace SOLID_Examples.DIP_Violation;

public class CreditCard
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount}");
    }
}