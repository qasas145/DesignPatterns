public class CommandInvoker {
    public List<ICommand> commandLines = new();
    public void AddCommand(ICommand command) {
        commandLines.Add(command);
    }
    public void ExecuteCommands() {
        foreach(var command in commandLines) {
            command.Execute();
        }
    }
}