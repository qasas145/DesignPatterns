public class CommandInvoker {
    public List<ICommand> commandLines = new();
    private Stack<ICommand> DoneCommands = new();
    private Stack<ICommand> UndoCommands = new();
    public void AddCommand(ICommand command) {
        commandLines.Add(command);
    }
    public void ExecuteCommands() {
        foreach(var command in commandLines)
        {
            ExecuteCommand(command);
        }
    }

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        DoneCommands.Push(command);
    }
    public void Undo() {
        var command = DoneCommands.Pop();
        command.Undo();
        UndoCommands.Push(command);
    }
    public void Redo() {
        var command = UndoCommands.Pop();
        ExecuteCommand(command);
    }
}