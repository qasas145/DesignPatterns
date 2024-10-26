public class CEOVacationHandler : VacationHandler
{
    public override void Handle(VacactionRequest request)
    {

        if (request.Employee.JobTitle == JobTitle.CTO || request.Employee.JobTitle == JobTitle.CEO) {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The vacation request has been approved from the CEO");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}