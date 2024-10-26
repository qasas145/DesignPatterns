public class TechnicalManagerVacationHanlder : VacationHandler
{
    public override void Handle(VacactionRequest request)
    {
        if (request.Employee.JobTitle == JobTitle.TeamLeader || request.Employee.JobTitle == JobTitle.Developer && (int)request.TotalDays > 3) {
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The vacation request has been approved from the technical manager");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else {
            _next.Process(request);
        }
    }
}