using Shared.Data.Base;

namespace Shared.Data.Models;

public class Entity2(int id, string name) : EntityBase(id,name)
{
    public override string ToString()
    {
        return $"{nameof(Id)}={Id};{nameof(Name)}={Name}";
    }
}