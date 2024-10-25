public class VisaPayment : PaymentProcessor
{
    public override IPaymentMethod CreatePaymentMethod()
    {
        return new VisPaymentMethod();
    }
}