public class ValidateDates : VacationHandler
{
    public override void Handle(VacactionRequest request)
    {
        if (request.TotalDays > 0) {
            _next.Process(request);
        }
        else {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid Period");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}