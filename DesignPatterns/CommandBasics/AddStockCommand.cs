public class AddStockCommand : ICommand
{
    private ProductC _product;
    private int _stock;

    public AddStockCommand(ProductC product, int stock) {
        _product = product;
        _stock = stock;
    }
    public void Execute()
    {
        _product.AddStock(_stock);
    }
}
