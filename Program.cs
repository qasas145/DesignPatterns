using System.Text;
using System.Text.Json;

public class Program {
    public static async Task AdapterSeeding() {

        // reading employee 
        var emps = new EmployeeReader().GetEmployees().Select(e=>new EmployeeAAdapter(e));

        var clinet = new HttpClient();
        foreach (var item in emps)
        {
            HttpRequestMessage msg = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5245/api/home");   

            msg.Content = new StringContent(JsonSerializer.Serialize(item), Encoding.UTF8, "application/json");

            var response = await clinet.SendAsync(msg);
            var responseJson = await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseJson);
        }

    }
    public static void Main(string[] args) {


        #region Singleton
        /*
        while (true) {

            Console.Write("Enter the id of the employee : ");

            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter the rate of emp {0} :", id);
            decimal rate = decimal.Parse(Console.ReadLine());

            var salary = Employee.employee.GetSalary(id, rate);

            Console.WriteLine("The salary of this employee is {0}", salary);
            Console.WriteLine();

        }
        */
        #endregion

        #region Adapter
        /*AdapterSeeding().GetAwaiter().GetResult();*/

        #endregion
        
        #region Stragety 
        /*
        var s = new StragetySeeding();
        s.Seeding();
        */
        
        #endregion
        
        #region SimpleFactory
        // actually the simple factoy was very simple so it's not important to make independat section for it ,

        #endregion

        #region NullObjects
        // done 
        #endregion 

        #region Template method 
        // new TemplateMethodSeeding().Seeding();
        #endregion

        #region Factory Method 
        // new TemplateMethodSeeding().Seeding(); // there's a part here related to TemplateMethod 
        #endregion

        #region State Design Pattern
        // new OrderSeeding().Seeding();
        #endregion

        #region Command Basics design pattern
        // new CommandBasicsSeeding().Seeding();
        #endregion

        #region Command Macros
        // new CommandMacrosSeeding().Seeding();
        #endregion

        #region Command Undo Redo 
        // new CommandUndoRedoSeeding().Seeding();
        #endregion

        #region Memento 
        // new MementoSeeding().Seeding();
        #endregion

        #region Builder
        new BuilderSeeding().Seeding();
        #endregion
        

        
    }
}