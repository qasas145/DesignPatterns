public class CommandBasicsSeeding {
    public void Seeding(){

        // bunch of productCs 
        var laptop = new ProductC(){Id = 1, Name = "Laptop", UnitPrice = 50, StockBalance = 100};
        var food = new ProductC(){Id = 2, Name = "Food", UnitPrice = 50, StockBalance = 200};
        var koshri = new ProductC(){Id = 3, Name = "Koshri", UnitPrice = 50, StockBalance = 50};

        var order = new OrderC();
        var commandInvoker = new CommandInvoker();

        Console.WriteLine("List of productCs");
        Console.WriteLine(laptop.ToString());
        Console.WriteLine(food.ToString());
        Console.WriteLine(koshri.ToString());

        while(true) {

            Console.Write("Choose one productC or 0 to exit ");

            var productCId = int.Parse(Console.ReadLine());

            if(productCId == 0)
                break;
            else if (productCId == 1 ) {
                commandInvoker.AddCommand(new AddProductCommand(order, laptop));
                commandInvoker.AddCommand(new AddStockCommand(laptop, -1));
            }
            else if (productCId == 2 ) {
                commandInvoker.AddCommand(new AddProductCommand(order, food));
                commandInvoker.AddCommand(new AddStockCommand(food, -1));
            }
            else if (productCId == 3 ) {
                commandInvoker.AddCommand(new AddProductCommand(order, koshri));
                commandInvoker.AddCommand(new AddStockCommand(koshri, -1));
            }

        }
        
        commandInvoker.ExecuteCommands();

    }
}