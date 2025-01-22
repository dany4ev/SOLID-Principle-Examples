namespace SOLID_Examples.DSP_Applied;

public class CreditCard : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount}");
    }
}