public class AddProductCommand : ICommand
{
    public  OrderC _order{get;set;}
    private ProductC _product;

    public AddProductCommand(OrderC order, ProductC product) {
        _order = order;
        _product = product;
    }
    public void Execute()
    {
        _order.AddOrder(_product);
    }

    public void Undo()
    {
        _order.RemoveAtIndex(_order.OrderLines.Count()-1);
    }
}
