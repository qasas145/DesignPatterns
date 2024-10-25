public class CareTaker {
    private List<Memento> _mementos = new();
    public IEnumerable<Memento> GetMementos => _mementos.AsReadOnly();
    public void AddMemento(Memento newMemento) {
        _mementos.Add(newMemento);
    }
    public Memento GetMemento(int id) {
        return _mementos.Find(m=>m.Id == id);
    }

    private CareTaker(){}
    public static readonly CareTaker Instance = new();

}