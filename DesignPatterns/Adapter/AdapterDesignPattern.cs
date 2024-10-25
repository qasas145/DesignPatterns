public class EmployeeA {
    public int Id{get;set;}
    public IEnumerable<PayItem> PayItems{get;set;}
}

public class EmployeeAAdapter {
    public EmployeeAAdapter(EmployeeA employee) {
        this.Id = employee.Id;
        this.payItems = employee.PayItems.Select(p=>new PayItemAdapter(p));
    }
    public int Id{get;set;}
    public IEnumerable<PayItemAdapter> payItems{get;set;}
}

public class PayItemAdapter {

    public string Name { get;set; }
    public decimal Value{get;set;}
    public PayItemAdapter(PayItem payItem) {

        Name = payItem.Name;
        this.Value = (payItem.IsNegative == true)?payItem.Value*-1:payItem.Value;

    }

}