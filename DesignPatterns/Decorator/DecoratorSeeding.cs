public class DecoratorSeeding {
    public void Seeding() {
        IOrderProcessor processor = new OrderProcessor();
        processor = new OrderProcessorProfiling(processor);
        processor = new OrderProcessorExceptionHandling(processor);
        processor.Process(new OrderC());
    }
}