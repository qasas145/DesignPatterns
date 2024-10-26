public class OrderProcessor : IOrderProcessor
{

    public void Process(OrderC order)
    {
        
        throw new Exception("Error ");
        Thread.Sleep(Random.Shared.Next(1000, 2000));
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The order has been processed sucessfully");
        Console.ForegroundColor = ConsoleColor.White;
    }
}