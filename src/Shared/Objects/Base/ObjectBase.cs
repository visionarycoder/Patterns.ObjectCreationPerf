namespace Shared.Objects.Base;

public abstract class ObjectBase(int id, string name)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
} 
