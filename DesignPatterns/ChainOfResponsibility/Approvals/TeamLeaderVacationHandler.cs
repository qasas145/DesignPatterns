public class TeamLeaderVacationHandler : VacationHandler
{
    public override void Handle(VacactionRequest request)
    {
        if (request.Employee.JobTitle == JobTitle.Developer && (int)request.TotalDays <= 3) {
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The vacation request has been approved from the team leader");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else {
            _next.Process(request);
        }
    }

}