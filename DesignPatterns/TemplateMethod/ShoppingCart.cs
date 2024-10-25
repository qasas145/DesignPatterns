public abstract class ShoppingCart {
    public InvoiceTemplate AddItem(InvoiceTemplate invoice, InvoiecLineTemplate invoiceLineTemplate) {
        invoice.InvoiceLines.Add(invoiceLineTemplate);
        return invoice;
    }
    public abstract void Discount(InvoiceTemplate invoice); // template method 
    public void Checkout(Customer customer, InvoiceTemplate invoice,PaymentProcessor paymentProcessor) {

        var payment = paymentProcessor.ProcessPayment(customer.Id, (double)invoice.NetPrice);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The invoice for {0} has been processed with reference number {1}", customer.Id, payment.ReferenceNumber);
        Console.WriteLine("and the charged amount is {0}", payment.ChargedAmount);
        Console.ForegroundColor = ConsoleColor.White;
        
    }
}