public class PaypalPaymentMethod : IPaymentMethod
{
    public Payment Charge(int customerId, double amount)
    {
        return new Payment() {
            customerId = customerId, 
            ChargedAmount = amount+.02*amount,
            ReferenceNumber = Guid.NewGuid()
        };
    }

}