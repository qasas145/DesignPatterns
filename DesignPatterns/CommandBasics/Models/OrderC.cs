
public class OrderC : Order{
    public void AddOrder(ProductC product) { 
        this.OrderLines.Add(
            new OrderLine(){ProductId = product.Id, UnitPrice = product.UnitPrice, Quantity = 1}
        );
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("The product {0} has been added", product.Name);
        Console.ForegroundColor = ConsoleColor.White;
    }

    internal void RemoveAtIndex(int v)
    {
        OrderLines.RemoveAt(v);
    }

    internal void TakeMemento() {
        var memento = new Memento(){OrderLines = OrderLines.Select(oL=>oL).ToList()};
        CareTaker.Instance.AddMemento(memento);
    }
    internal void ReturnToMemento(int id) {
        var memento = CareTaker.Instance.GetMemento(id);
        OrderLines = memento.OrderLines;
    }
}