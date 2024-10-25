public class Order {
    public OrderStatus OrderStatus {get;set;}
    public List<OrderLine> OrderLines{get;set;}
    public int TotalPrice=>OrderLines.Sum(o=>o.Quantity*o.UnitPrice);

    public Order() {
        OrderStatus = new OrderStatus(){Status = new  OrderDraft()};
    }
    public void SetStatus(OrderStatus status) {

        // if (
        //     this.OrderStatus == OrderStatus.Shipped && status!= OrderStatus.Delivered ||
        //     this.OrderStatus == OrderStatus.UnderProcessing && status != OrderStatus.Shipped ||
        //     this.OrderStatus == OrderStatus.Confirmed && status != OrderStatus.Canceled && status != OrderStatus.UnderProcessing ||
        //     this.OrderStatus == OrderStatus.Draft && status != OrderStatus.Confirmed ||
        //     this.OrderStatus == OrderStatus.Delivered && status != OrderStatus.Returned
        // )
        //     throw new ArgumentException("This status isn't allowed");
        // else 
        //     OrderStatus = status;

    }

}