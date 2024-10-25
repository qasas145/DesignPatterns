public class MacrosStorage {
    public static int Id{get; private set;}
    public List<Macro> Macros = new();
    public IEnumerable<Macro> GetMacros => Macros.AsReadOnly();
    public Macro GetMacro(int id)=> GetMacros.ToList()[id];
    public void AddMacro(Macro macro) {
        macro.Id = Id;
        Macros.Add(macro);
        Id+=1;
    } 
    public static MacrosStorage Instance = new MacrosStorage();
    private MacrosStorage(){
        
    }

}