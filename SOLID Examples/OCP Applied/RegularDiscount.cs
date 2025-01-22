namespace SOLID_Examples.OCP_Applied_Example;

public class RegularDiscount : IDiscountStrategy
{
    public double CalculateDiscount(double price)
    {
        return price * 0.1;
    }
}