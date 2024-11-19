namespace ObjectCreation.Client;

public class ExecutionSummary(Type type, int range, TimeSpan activatorTime, TimeSpan newTime)
{
    public Type Type { get; } = type;
    public int Range { get; } = range;
    public TimeSpan ActivatorTime { get; } = activatorTime;
    public TimeSpan NewTime { get; } = newTime;
}