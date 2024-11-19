#pragma warning disable CS8618, CS9264

namespace Shared.Objects.Models;

public class Object8(int id, string name, decimal price, DateTime created, bool isActive, string description, string category, int stock) : Object4(id, name, price, created)
{

    public Object8() : this(0, string.Empty, 0, DateTime.Now, false, string.Empty, string.Empty, 0)
    {
    }

    public bool IsActive { get; set; } = isActive;
    public string Description { get; set; } = description;
    public string Category { get; set; } = category;
    public int Stock { get; set; } = stock;

    public override string ToString()
    {
        return $"{nameof(Id)}={Id};{nameof(Name)}={Name};{nameof(Price)}={Price};{nameof(Created)}={Created};{nameof(IsActive)}={IsActive};{nameof(Description)}={Description};{nameof(Category)}={Category};{nameof(Stock)}={Stock}";
    }

}