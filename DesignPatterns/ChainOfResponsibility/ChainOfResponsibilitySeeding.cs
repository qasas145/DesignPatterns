public class ChainOfResponsibilitySeeding {
    public void Seeding() {
        var employee = new EmployeeC() {
            Id = 1,
            Name = "Muhammad Elsayed Elqasas",
            JobTitle = JobTitle.Developer
        };
        var request = new VacactionRequest(){
            Employee = employee,
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddDays(-2),
        };

        var validateDates =new ValidateDates();
        var CTOVacationHandler = new CTOVacationHandler();
        var CEOVacationHandler = new CEOVacationHandler();
        var teamLeaderVacationHandler = new TeamLeaderVacationHandler();
        var technicalVacationHandler = new TechnicalManagerVacationHanlder();
        
        validateDates.SetNext(teamLeaderVacationHandler);
        teamLeaderVacationHandler.SetNext(technicalVacationHandler);
        technicalVacationHandler.SetNext(CTOVacationHandler);
        CTOVacationHandler.SetNext(CEOVacationHandler);

        validateDates.Process(request);

    }
}