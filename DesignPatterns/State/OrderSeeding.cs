public class OrderSeeding {
    public void Seeding(){
        var products = new List<Product>(){
            new Product(){Id = 1, Name = "Laptop", UnitPrice = 50},
            new Product(){Id = 2, Name = "Food", UnitPrice = 50},
            new Product(){Id = 3, Name = "Koshri", UnitPrice = 50},
        };
        var orderLines = new List<OrderLine>();
        var order = new Order();
        Console.WriteLine("List of products");
        foreach (var product in products)
        {
            Console.WriteLine(product.ToString());
        }
        while(true) {
            Console.Write("Choose one product or 0 to exit ");
            var productId = int.Parse(Console.ReadLine());
            if(productId == 0)
                break;
            Console.Write("Enter the quantity : ");
            var quantity = int.Parse(Console.ReadLine());

            var product = products.Find(p=>p.Id == productId);
            orderLines.Add(new OrderLine(){ProductId = productId, Quantity = quantity, UnitPrice = product.UnitPrice});
        }
        while (true) {
            try{
                Console.WriteLine("{0}", order.OrderStatus.Status.GetType().ToString());
                Console.Write("Enter the new order status or 0 to exit: ");
                var newStatus = Console.ReadLine();
                if (newStatus == "0")
                    break;
                else if (newStatus.ToLower() == "draft")
                    order.OrderStatus.Draft();
                else if (newStatus.ToLower() == "confirmed") 
                    order.OrderStatus.Confirm();
                else if (newStatus.ToLower() == "canceled")
                    order.OrderStatus.Cancel();
                else if (newStatus.ToLower() == "underprocessing")
                    order.OrderStatus.UnderProcessing();
                else if (newStatus.ToLower() == "shipped")
                    order.OrderStatus.Shipp();
                else if (newStatus.ToLower() == "delivered")
                    order.OrderStatus.Deliver();
                else if (newStatus.ToLower() == "returned")
                    order.OrderStatus.Return();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Status set to {0}", newStatus);
                Console.ForegroundColor = ConsoleColor.White;

            
            }catch(NotImplementedException e) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You arn't allowed to change to this state");
                Console.ForegroundColor = ConsoleColor.White;

            }

        }
    }
}