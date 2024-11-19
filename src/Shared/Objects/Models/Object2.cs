using Shared.Objects.Base;

#pragma warning disable CS8618, CS9264
namespace Shared.Objects.Models;

public class Object2(int id, string name) : ObjectBase(id, name)
{
    public Object2() : this(0,string.Empty)
    {
        
    }

    public override string ToString()
    {
        return $"{nameof(Id)}={Id};{nameof(Name)}={Name};";
    }

}