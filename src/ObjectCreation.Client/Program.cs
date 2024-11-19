using System.Diagnostics;

using ObjectCreation.Client;
using Shared.Objects.Models;

var ranges = new[] { 1_000, 10_000, 100_000, 1_000_000, 10_000_000, 100_000_000, 1_000_000_000 };
var results = new List<ExecutionSummary>();

results.AddRange(Run<Object0>(ranges));
results.AddRange(Run<Object2>(ranges));
results.AddRange(Run<Object4>(ranges));
results.AddRange(Run<Object8>(ranges));

Console.WriteLine("{0,15} | {1,15} | {2,15}", "Range", "Activator", "New");
Console.WriteLine(new string('-', 50));
Type? lastType = default;

foreach (var result in results)
{
    
    if (lastType != result.Type)
    {
        Console.WriteLine(result.Type.Name);
        Console.WriteLine(new string('-', 50));
        lastType = result.Type;
    }
    Console.WriteLine("{0,15:#,0} | {1,15} | {2,15}", result.Range, result.ActivatorTime, result.NewTime);

}

Console.WriteLine(new string('-', 50));
Console.WriteLine("Finished! Press any key to exit.");
Console.ReadLine();
return;

static List<ExecutionSummary> Run<T>(int[] ranges) where T : new()
{

    var list = new List<ExecutionSummary>();
    var stopwatch = new Stopwatch();
    var type = typeof(T);

    foreach (var range in ranges)
    {
        stopwatch.Restart();
        foreach (var _ in Enumerable.Range(0, range))
        {
            var instance = InstantiationFactory.Activate<T>();
        }
        var activatorTime = stopwatch.Elapsed;

        stopwatch.Restart();
        foreach (var _ in Enumerable.Range(0, range))
        {
            var instance = InstantiationFactory.New<T>();
        }
        var newTime = stopwatch.Elapsed;

        list.Add(new ExecutionSummary(type, range, activatorTime, newTime));
    }
    
    return list;

}


