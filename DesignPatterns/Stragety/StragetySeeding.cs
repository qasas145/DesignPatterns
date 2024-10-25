public enum States {
    New = 1,
    Gold,
    Silver,
    None
}
public class StragetySeeding {
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
        Console.Write("Enter the id of the customer : ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter the quantity : ");
        int quantity = int.Parse(Console.ReadLine());
        Console.Write("Enter the unit price : ");
        int unitPrice = int.Parse(Console.ReadLine());

        var cust = customers.Find(c=>c.Id == id);


        // this simple with factory 
        IDiscountStragety stragety = new CustomerDiscountStragetyFactory()
            .CreateCustomerDiscountStragety(cust.Status);

        var invoiceManager = new InvoiceManager(stragety);
        var invoice = invoiceManager.GenerateInvoice(cust, quantity, unitPrice);
        
        Console.WriteLine("The customer {0} has buyed by total {1}", invoice.Customer.Id, invoice.NetPrice);
    }
}