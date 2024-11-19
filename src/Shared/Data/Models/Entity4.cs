namespace Shared.Data.Models;

public class Entity4(int id, string name, decimal price, DateTime created) : Entity2(id, name)
{
    public decimal Price { get; set; } = price;
    public DateTime Created { get; set; } = created;

    public override string ToString()
    {
        return $"{nameof(Id)}={Id};{nameof(Name)}={Name};{nameof(Price)}={Price};{nameof(Created)}={Created};";
    }

}