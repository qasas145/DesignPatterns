public interface IOrderStatus {
    public void UnderProcessing();
    public void Confirm();
    public void Cancel();
    public void Shipp();
    public void Draft();
    public void Return();
    public void Deliver();
}