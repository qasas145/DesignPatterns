
public class CommandUndoRedoSeeding {
    public void Seeding(){

        // bunch of productCs 
        var laptop = new ProductC(){Id = 1, Name = "Laptop", UnitPrice = 50, StockBalance = 100};
        var food = new ProductC(){Id = 2, Name = "Food", UnitPrice = 50, StockBalance = 200};
        var koshri = new ProductC(){Id = 3, Name = "Koshri", UnitPrice = 50, StockBalance = 50};

        var order = new OrderC();
        var commandInvoker = new CommandInvokerChild();

        Console.WriteLine("List of productCs");
        Console.WriteLine(laptop.ToString());
        Console.WriteLine(food.ToString());
        Console.WriteLine(koshri.ToString());
        Console.WriteLine("\t4 : Undo");
        Console.WriteLine("\t5 : Redo");
        Console.WriteLine("\t0 : Process");
        Console.Write(" : ");

        while(true) {

            
            var productCId = int.Parse(Console.ReadLine());

            if(productCId == 0){
                var totalPrice = order.OrderLines.Sum(o=>o.Quantity*o.UnitPrice);
                var totalQuantities = order.OrderLines.Count();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("The total price is {0}", totalPrice);
                Console.WriteLine("The total quantities are {0}", totalQuantities);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (productCId == 1 ) {
                commandInvoker.ExecuteCommand(new AddProductCommand(order, laptop));
                commandInvoker.ExecuteCommand(new AddStockCommand(laptop, -1));
            }
            else if (productCId == 2 ) {
                commandInvoker.ExecuteCommand(new AddProductCommand(order, food));
                commandInvoker.ExecuteCommand(new AddStockCommand(food, -1));
            }
            else if (productCId == 3 ) {
                commandInvoker.ExecuteCommand(new AddProductCommand(order, koshri));
                commandInvoker.ExecuteCommand(new AddStockCommand(koshri, -1));
            }
            else if (productCId == 4) {
                commandInvoker.Undo();
                commandInvoker.Undo();
            }
            else if (productCId == 5) {
                commandInvoker.Redo();
                commandInvoker.Redo();
            }

        }
        

    }

}