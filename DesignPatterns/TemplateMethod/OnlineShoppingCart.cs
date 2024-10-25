public class OnlineShoppingCart : ShoppingCart
{
    public override void Discount(InvoiceTemplate invoice)
    {
        invoice.Discount = .01M;
    }
}