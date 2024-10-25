
public class InvoiceManager {
    

    public IDiscountStragety _staragety;
    public InvoiceManager(IDiscountStragety stragety) {
        _staragety = stragety;
    }
    public Invoice GenerateInvoice(Customer customer, int quantity, int unitPrice) {

        var invoice = new Invoice() {
            Customer = customer,
            InvoiceLines = new List<InvoiceLine>() { new InvoiceLine() {
                    Quantity = quantity,
                    UnitPrice = unitPrice,
                }
            }
        };
        invoice.Discount = _staragety.DiscountRate(invoice.TotalPrice);
        return invoice;
    }
}
public interface IDiscountStragety {
    public decimal DiscountRate(decimal totalPrice);
}
public class NewCustomerDiscountStargety : IDiscountStragety
{
    public decimal DiscountRate(decimal totalPrice)
    {
        return 0;
    }
}

public class SilverCustomerDiscountStargety : IDiscountStragety
{
    public decimal DiscountRate(decimal totalPrice)
    {
        return totalPrice>1000? .02M: 0;
    }
}
public class GoldCustomerDiscountStargety : IDiscountStragety
{
    public decimal DiscountRate(decimal totalPrice)
    {
        return totalPrice>1000? .01M: 0;

    }
}