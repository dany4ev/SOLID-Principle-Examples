namespace SOLID_Examples.DSP_Applied;

public class PayPal : IPaymentMethod
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of {amount}");
    }
}