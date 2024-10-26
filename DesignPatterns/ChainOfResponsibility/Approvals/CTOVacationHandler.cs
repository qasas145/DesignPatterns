public class CTOVacationHandler : VacationHandler
{
    public override void Handle(VacactionRequest request)
    {

        if (request.Employee.JobTitle == JobTitle.TechnicalManager ) {
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The vacation request has been approved from the CTO");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else {
            _next.Process(request);
        }
    }
}