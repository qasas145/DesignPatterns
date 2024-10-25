public class NullCustomerDiscountStragety : IDiscountStragety
{
    public decimal DiscountRate(decimal totalPrice)
    {
        return 0;
    }
}