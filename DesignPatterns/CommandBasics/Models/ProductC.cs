public class ProductC : Product {
    public int StockBalance{get;set;}
    public void AddStock(int stock) {
        StockBalance += stock;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("The stock has changed to {0}", this.StockBalance);
        Console.ForegroundColor = ConsoleColor.White;
    }
    public override string ToString()
    {
        return base.ToString()+$"- {this.StockBalance}";
    }
}