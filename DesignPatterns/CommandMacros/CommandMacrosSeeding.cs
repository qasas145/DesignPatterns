
public class CommandMacrosSeeding {
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

        while(true) {

            Console.WriteLine("Choose one productC or 0 to exit ");
            Console.WriteLine("4 : save the macro");
            Console.Write("5 : replay the macro ");
            
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
            else if (productCId == 4){
                Macro macro = new Macro() {
                    Order = order,
                    Commands = commandInvoker.GetCommands.ToList(),
                };
                MacrosStorage.Instance.AddMacro(macro);
                commandInvoker.ClearCommands();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The macro has been saved sucessfully");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (productCId == 5) {
                ReplyMacro(commandInvoker);
            }

        }
        

    }

    private void ReplyMacro(CommandInvokerChild commandInvoker)
    {

        OrderC order = new OrderC();
        foreach(var macro in MacrosStorage.Instance.GetMacros) {
            Console.WriteLine(macro.ToString());
        }
        Console.Write("Enter the id of the macro : ");
        int id = int.Parse(Console.ReadLine());
        var selectMacro = MacrosStorage.Instance.GetMacro(id);
        foreach (var command in selectMacro.GetCommands)
        {
            if (command is AddProductCommand addProductCommand) 
                addProductCommand._order = order;
            commandInvoker.AddCommand(command);
        }
        commandInvoker.ExecuteCommands();
        commandInvoker.ClearCommands();
    }
}