public class Product {
    public int Id{get;set;}
    public string Name{get;set;}
    public int UnitPrice{get;set;}
    public override string ToString()
    {
        return $"\t{this.Id} : {this.Name} - {this.UnitPrice}";
    }
}