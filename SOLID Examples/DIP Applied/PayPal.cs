namespace SOLID_Examples.DIP_Applied;

public class PayPal : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of {amount}");
    }
}