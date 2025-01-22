namespace SOLID_Examples.DIP_Violation;

public class PaymentProcessor
{
    public void ExecutePayment(decimal amount)
    {
        var creditCard = new CreditCard();
        creditCard.ProcessPayment(amount);
    }
}