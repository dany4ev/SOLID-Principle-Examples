namespace SOLID_Examples.DIP_Applied;

public interface IPaymentMethod
{
    void ProcessPayment(decimal amount);
}