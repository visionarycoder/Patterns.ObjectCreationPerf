#pragma warning disable CS8618, CS9264

namespace Shared.Objects.Models;

public class Object4(int id, string name, decimal price, DateTime created) : Object2(id, name)
{
    public Object4() : this(0, string.Empty, 0, DateTime.Now)
    {

    }

    public decimal Price { get; set; } = price;
    public DateTime Created { get; set; } = created;

    public override string ToString()
    {
        return $"{nameof(Id)}={Id};{nameof(Name)}={Name};{nameof(Price)}={Price};{nameof(Created)}={Created};";
    }

}