public class Memento {
    public int Id = Random.Shared.Next();
    public List<OrderLine> OrderLines{get;set;}
    public override string ToString()
    {
        return $"{Id} - {OrderLines.Count()}";
    }
}