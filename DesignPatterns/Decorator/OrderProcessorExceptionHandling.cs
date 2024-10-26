public class OrderProcessorExceptionHandling : IOrderProcessor
{
    private readonly IOrderProcessor orderProcessor;

    public OrderProcessorExceptionHandling(IOrderProcessor orderProcessor)
    {
        this.orderProcessor = orderProcessor;
    }

    public void Process(OrderC order)
    {
        try {
            orderProcessor.Process(order);
        }catch(Exception e) {
            Console.WriteLine(e.Message);
        }
    }
}
