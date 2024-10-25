public class InvoiceTemplate {
    public List<InvoiecLineTemplate> InvoiceLines{get;set;}
    
    public Customer Customer{get;set;}

    public decimal Discount{get;set;}
    public decimal TotalPrice=>InvoiceLines.Sum(l=>l.Quantity*l.UnitPrice);
    public decimal NetPrice => TotalPrice - TotalPrice * Discount;
}