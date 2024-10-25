
public class Invoice {
    public Customer Customer{get;set;}
    public List<InvoiceLine> InvoiceLines{get;set;}

    public decimal Discount{get;set;}
    public decimal TotalPrice=>InvoiceLines.Sum(l=>l.Quantity*l.UnitPrice);
    public decimal NetPrice => TotalPrice - TotalPrice * Discount;
}
