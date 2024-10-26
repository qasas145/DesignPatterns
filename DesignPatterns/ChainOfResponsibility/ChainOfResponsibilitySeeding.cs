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
            EndDate = DateTime.Now.AddDays(4),
        };

        var CTOVacationHandler = new CTOVacationHandler();
        var CEOVacationHandler = new CEOVacationHandler();
        var teamLeaderVacationHandler = new TeamLeaderVacationHandler();
        var technicalVacationHandler = new TechnicalManagerVacationHanlder();
        
        teamLeaderVacationHandler.SetNext(technicalVacationHandler);
        technicalVacationHandler.SetNext(CTOVacationHandler);
        CTOVacationHandler.SetNext(CEOVacationHandler);

        teamLeaderVacationHandler.Process(request);

    }
}