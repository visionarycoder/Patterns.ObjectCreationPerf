using ObjectCreation.Client;
using Shared.Objects.Models;
using System.Diagnostics;

var ranges = new[] { 1_000, 10_000, 100_000, 1_000_000 }; //, 10_000_000, 100_000_000, 1_000_000_000 };
var results = new List<ExecutionSummary>();

results.AddRange(Run<Object0>(ranges));
results.AddRange(Run<Object2>(ranges));
results.AddRange(Run<Object4>(ranges));
results.AddRange(Run<Object8>(ranges));

var typeName = "Type".PadLeft(20);
var range = "Range".PadLeft(20);
var activator = "Activator".PadLeft(20);
var newColumn = "New".PadLeft(20);
var header = new string($" {typeName} | {range} | {activator} | {newColumn}");

Console.WriteLine(header);
Console.WriteLine("".PadRight(header.Length, '-'));

foreach (var result in results)
{
    Console.WriteLine("{0,20} | {1,20:#,0} | {2,20} | {3,20}", result.Type.Name, result.Range, result.ActivatorTime, result.NewTime);
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

        Console.WriteLine($"Running {type.Name} for {range:#,0} iterations");
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