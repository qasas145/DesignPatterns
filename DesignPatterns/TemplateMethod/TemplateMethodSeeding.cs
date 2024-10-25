public class TemplateMethodSeeding {
    public void Seeding() {
        
        var customers = new List<Customer>() {
            new Customer() {
                Id = 1,
                Status = States.New
            },
            new Customer() {
                Id = 2,
                Status = States.Silver
            },
            new Customer() {
                Id = 3,
                Status = States.Gold
            },
            new Customer() {
                Id = 4,
                Status = States.None
            }

        };
        
        var invoiceLines = new List<InvoiecLineTemplate>(){
            new InvoiecLineTemplate() {Id = 1, Name = "laptop", UnitPrice = 200},
            new InvoiecLineTemplate() {Id = 2, Name = "food", UnitPrice = 100},
            new InvoiecLineTemplate() {Id = 3, Name = "fish", UnitPrice = 50},
        };
        Console.WriteLine("List of customers");
        foreach(var c in customers) {
            Console.WriteLine("    {0} - {1}", c.Id, c.Status);
        }
        Console.WriteLine("List of Items");
        
        foreach(var invoiceLine in invoiceLines) {
            Console.WriteLine("    {0} - {1} : {2}", invoiceLine.Id, invoiceLine.Name, invoiceLine.UnitPrice);
        }
        
        Console.Write("Enter the id of the customer : ");
        int id = int.Parse(Console.ReadLine());
        var customer = customers.Find(c=>c.Id == id);

        // determining whether paypal payment or visa payment and this related to the factory method design pattern

        Console.Write("1 for paypal or 2 for visa : ");
        PaymentProcessor paymentProcessor= int.Parse(Console.ReadLine()).Equals(1)?new PaypalPayment() : new VisaPayment();

        Console.Write("1 for online shopping cart and 2 for in store shopping cart : ");
        ShoppingCart shoppingCart = int.Parse(Console.ReadLine()).Equals(1)? new OnlineShoppingCart() : new InStoreShoppingCart();

        
        InvoiceTemplate invoiceTemplate = new InvoiceTemplate(){
            Customer = customer, 
            InvoiceLines = new List<InvoiecLineTemplate>()
        };

        do {
                
            Console.Write("Enter the id of the item or 0 to close: ");
            int invoiceLineId = int.Parse(Console.ReadLine());
            if (invoiceLineId == 0) break;
            Console.Write("Enter the quantity : ");
            int quantity = int.Parse(Console.ReadLine());

            var invoiceLine01 = invoiceLines.Find(i=>i.Id == invoiceLineId);
            invoiceLine01.Quantity = quantity;

            shoppingCart.AddItem(invoiceTemplate, invoiceLine01);

        }while(true);

        shoppingCart.Discount(invoiceTemplate); // template method
        shoppingCart.Checkout(customer, invoiceTemplate, paymentProcessor); // the paymentProcessor attribute is related to the factory method design pattern 

        Console.WriteLine("The total price is {0}", invoiceTemplate.NetPrice);
    }
    
}
