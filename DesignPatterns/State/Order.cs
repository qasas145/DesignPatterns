public class Order {
    public OrderStatus OrderStatus {get;set;}
    public List<OrderLine> OrderLines =new();
    public int TotalPrice=>OrderLines.Sum(o=>o.Quantity*o.UnitPrice);

    public Order() {
        OrderStatus = new OrderStatus(){Status = new  OrderDraft()};
    }

}