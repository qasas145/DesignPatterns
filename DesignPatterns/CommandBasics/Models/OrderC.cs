public class OrderC : Order{
    public void AddOrder(ProductC product) { 
        this.OrderLines.Add(
            new OrderLine(){ProductId = product.Id, UnitPrice = product.UnitPrice}
        );
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("The product {0} has been added", product.Name);
        Console.ForegroundColor = ConsoleColor.White;
    }
}