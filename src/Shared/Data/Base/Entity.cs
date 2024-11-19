namespace Shared.Data.Base;

public abstract class Entity
{
    public int Id { get; set; } = -1;
    public string Name { get; set; } = string.Empty;
}