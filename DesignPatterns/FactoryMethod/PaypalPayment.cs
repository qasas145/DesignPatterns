public class PaypalPayment : PaymentProcessor
{
    public override IPaymentMethod CreatePaymentMethod()
    {
        return new PaypalPaymentMethod();
    }
}