public class VisPaymentMethod : IPaymentMethod
{
    public Payment Charge(int customerId, double amount)
    {
        var commition = (amount>10000)?amount*.02 : 0;
        return new Payment(){
            customerId = customerId,
            ChargedAmount = amount+commition,
            ReferenceNumber = Guid.NewGuid()
        };
    }
}