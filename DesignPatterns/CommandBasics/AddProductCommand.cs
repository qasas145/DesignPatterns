public class AddProductCommand : ICommand
{
    private OrderC _order;
    private ProductC _product;

    public AddProductCommand(OrderC order, ProductC product) {
        _order = order;
        _product = product;
    }
    public void Execute()
    {
        _order.AddOrder(_product);
    }
}
