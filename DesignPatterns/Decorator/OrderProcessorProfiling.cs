using System.Diagnostics;

public class OrderProcessorProfiling : IOrderProcessor{
    public OrderProcessorProfiling(IOrderProcessor orderProcessor){
        _orderProcessor = orderProcessor;
    }

    private IOrderProcessor _orderProcessor;

    public void Process(OrderC order)
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();
        _orderProcessor.Process(order);
        stopWatch.Stop();
        Console.WriteLine("The time taken in seconds is {0}",stopWatch.Elapsed.TotalSeconds);
    }

}