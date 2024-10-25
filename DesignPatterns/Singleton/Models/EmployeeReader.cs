public class EmployeeReader {
    public IEnumerable<EmployeeA> GetEmployees() {
        return new [] {
            new EmployeeA(){
                Id = 1, 
                PayItems = new [] {
                    new PayItem(){Name = "main",Value = 1000},
                    new PayItem(){Name = "job",Value = 2400},
                    new PayItem(){Name = "affairs",Value = -150}

                }
            },
            new EmployeeA(){
                Id = 2, 
                PayItems = new [] {
                    new PayItem(){Name = "main",Value = 1000},
                    new PayItem(){Name = "job",Value = 2400},
                    new PayItem(){Name = "affairs",Value = 150, IsNegative = true}

                }
            }
        };
    }
}