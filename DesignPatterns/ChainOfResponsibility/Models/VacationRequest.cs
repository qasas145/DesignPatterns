public class VacactionRequest {
    public EmployeeC Employee{get;set;}
    public DateTime StartDate{get;set;}
    public DateTime EndDate{get;set;}
    public double TotalDays=>EndDate.Subtract(StartDate).TotalDays;
}