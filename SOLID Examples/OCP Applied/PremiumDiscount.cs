namespace SOLID_Examples.OCP_Applied_Example;

public class PremiumDiscount : IDiscountStrategy
{
    public double CalculateDiscount(double price)
    {
        return price * 0.3;
    }
}