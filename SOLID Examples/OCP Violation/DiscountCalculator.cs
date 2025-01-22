namespace SOLID_Examples.OCP_Violation_Example;

public class DiscountCalculator
{
    public double CalculateDiscount(double price, CustomerType customerType)
    {
        switch (customerType)
        {
            case CustomerType.Regular:
                return price * 0.1;  // 10% discount for regular customers
            case CustomerType.Premium:
                return price * 0.3;  // 30% discount for premium customers
            case CustomerType.Newbie:
                return price * 0.05; // 5% discount for new customers
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}