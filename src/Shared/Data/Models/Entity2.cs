#pragma warning disable CS8618, CS9264
using Shared.Data.Base;

namespace Shared.Data.Models;

public class Entity2(int id, string name) : Entity
{
    public override string ToString()
    {
        return $"{nameof(Id)}={Id};{nameof(Name)}={Name}";
    }
}