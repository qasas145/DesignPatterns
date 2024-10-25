public class Employee {
    private Employee() {
        SimulateLoading();
    }
    public int Id{get;set;}
    public string Name{get;set;}

    public static Employee _instance;

    public static object _lock = new();
    public static Employee employee{
        get{
            lock (_lock)
            {
                if (_instance is not Employee) {
                    _instance = new Employee();
                    return _instance;
                }
                return _instance;   
            }
        }
    }

    public decimal GetSalary(int Id, decimal Rate){
        return Rate*1000;
    }

    public void SimulateLoading() {
        Thread.Sleep(3000);
        Console.WriteLine("The data has been fetched");
    }

}