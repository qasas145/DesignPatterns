using System.Reflection.Metadata;

public abstract class VacationHandler : IVacationHandler
{
    public IVacationHandler _next{get; private set;}
    public void Process(VacactionRequest request)
    {
        Handle(request);
    }
    public abstract void Handle(VacactionRequest request);
    public void SetNext(IVacationHandler next) {
        _next = next;
    }
}
