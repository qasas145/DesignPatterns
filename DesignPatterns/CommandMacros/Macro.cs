public class Macro {
    public int Id{get;set;}
    public List<ICommand> Commands{private get;set;}
    public IEnumerable<ICommand> GetCommands => Commands.AsReadOnly();

    public Order Order{get;set;}
    public override string ToString()
    {
        return $"\t{Id} - with {Commands.Count()} commands";
    }

}