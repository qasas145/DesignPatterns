public class CommandInvokerChild : CommandInvoker {
    public IEnumerable<ICommand> GetCommands => commandLines.AsReadOnly();
    public void ClearCommands() => commandLines = new List<ICommand>();
}