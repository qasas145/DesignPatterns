public class OrderProcessorQueueing : IOrderProcessor
{
    private readonly IOrderProcessor orderProcessor;
    private Queue<IOrderProcessor> ordersQueue = new();

    public OrderProcessorQueueing(IOrderProcessor orderProcessor)
    {
        this.orderProcessor = orderProcessor;
    }

    public void Process(OrderC order)
    {
        ordersQueue.Enqueue(orderProcessor);
    }
}
