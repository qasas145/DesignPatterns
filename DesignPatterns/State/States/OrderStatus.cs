public class OrderStatus {
    public IOrderStatus Status{get;set;}
    
    public void Confirm() {
         Status.Confirm();
         Status = new OrderConfirm();
        
    }
    public void Draft() {
        Status.Draft();
         Status = new OrderDraft();

    }
    public void Shipp(){
        Status.Shipp();
        Status = new OrderShipp();


    }
    public void Cancel(){
        Status.Cancel();
         Status = new OrderCancel();


    }
    public void Return(){
        Status.Return();
         Status = new OrderReturn();

    }
    public void UnderProcessing(){
        Status.UnderProcessing();
        Status = new OrderUnderProcessing();

    }
    public void Deliver(){
        Status.Deliver();
        Status = new OrderDeliver();


    }
}