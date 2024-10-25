
public class MementoSeeding {
    public void Seeding(){

        // bunch of productCs 
        var laptop = new ProductC(){Id = 1, Name = "Laptop", UnitPrice = 50, StockBalance = 100};
        var food = new ProductC(){Id = 2, Name = "Food", UnitPrice = 50, StockBalance = 200};
        var koshri = new ProductC(){Id = 3, Name = "Koshri", UnitPrice = 50, StockBalance = 50};
        var mouse = new ProductC(){Id = 4, Name = "Mouse", UnitPrice = 50, StockBalance = 50};
        var keyboard = new ProductC(){Id = 5, Name = "Keyboard", UnitPrice = 50, StockBalance = 50};

        var order = new OrderC();
        var commandInvoker = new CommandInvokerChild();

        Console.WriteLine("List of productCs");
        Console.WriteLine(laptop.ToString());
        Console.WriteLine(food.ToString());
        Console.WriteLine(koshri.ToString());
        Console.WriteLine("\t4 : Undo");
        Console.WriteLine("\t5 : Redo");
        Console.WriteLine("\t6 : Save Memento");
        Console.WriteLine("\t7 : Back to Memento");
        Console.WriteLine("\t0 : Process");

        while(true) {
            var choice = int.Parse(Console.ReadLine());
            if(choice == 0){
                var totalPrice = order.OrderLines.Sum(o=>o.Quantity*o.UnitPrice);
                var totalQuantities = order.OrderLines.Count();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("The total price is {0}", totalPrice);
                Console.WriteLine("The total quantities are {0}", totalQuantities);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (choice == 1 ) {
                commandInvoker.ExecuteCommand(new AddProductCommand(order, laptop));
                commandInvoker.ExecuteCommand(new AddStockCommand(laptop, -1));
            }
            else if (choice == 2 ) {
                commandInvoker.ExecuteCommand(new AddProductCommand(order, food));
                commandInvoker.ExecuteCommand(new AddStockCommand(food, -1));
            }
            else if (choice == 3 ) {
                commandInvoker.ExecuteCommand(new AddProductCommand(order, koshri));
                commandInvoker.ExecuteCommand(new AddStockCommand(koshri, -1));
            }
            else if (choice == 4) {
                commandInvoker.Undo();
                commandInvoker.Undo();
            }
            else if (choice == 5) {
                commandInvoker.Redo();
                commandInvoker.Redo();
            }
            else if (choice == 6) {
                order.TakeMemento();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The memento has been taken sucessfully");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (choice == 7) {
                var mementos = CareTaker.Instance.GetMementos;
                Console.ForegroundColor = ConsoleColor.Blue;
                foreach(var memento in mementos){
                    Console.WriteLine(memento.ToString());
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter the id of the memento : ");
                int id = int.Parse(Console.ReadLine());
                order.ReturnToMemento(id);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The Memento has been fetched sucessfully");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
        

    }

}