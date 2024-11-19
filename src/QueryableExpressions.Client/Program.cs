using QueryableExpressions.Client.Helpers;
using Shared;
using Shared.Data.Models;
using Shared.Objects.Models;

namespace QueryableExpressions.Client;

internal class Program
{
    private static readonly int[] counts = { 1_000, 10_000, 100_000, 1_000_000, 10_000_000, 100_000_000, 1_000_000_000 };

    public static void Main(string[] args)
    {
        var list = new List<(Type Type, int Count, TimeSpan Elapsed)>();
        foreach (var count in counts)
        {
            {
                var data = new List<Entity2>();
                data.CreateDataset(count);
                list.Add((Helper.GetEntityType(data), count, EntityRunner.RunEntity(data, QueryableExpressions.Client.Filtering.ChatGPT.FilterExtensions.ApplyFilter)));
                list.Add((Helper.GetEntityType(data), count, EntityRunner.RunEntity(data, QueryableExpressions.Client.Filtering.CoPilot.FilterExtensions.ApplyFilter)));
            }

            {
                var data = new List<Entity4>();
                data.CreateDataset(count);
                list.Add((Helper.GetEntityType(data), count, EntityRunner.RunEntity(data, QueryableExpressions.Client.Filtering.ChatGPT.FilterExtensions.ApplyFilter)));
                list.Add((Helper.GetEntityType(data), count, EntityRunner.RunEntity(data, QueryableExpressions.Client.Filtering.CoPilot.FilterExtensions.ApplyFilter)));
            }

            {
                var data = new List<Entity8>();
                data.CreateDataset(count);
                list.Add((Helper.GetEntityType(data), count, EntityRunner.RunEntity(data, QueryableExpressions.Client.Filtering.ChatGPT.FilterExtensions.ApplyFilter)));
                list.Add((Helper.GetEntityType(data), count, EntityRunner.RunEntity(data, QueryableExpressions.Client.Filtering.CoPilot.FilterExtensions.ApplyFilter)));
            }

            {
                var data = new List<Object2>();
                data.CreateDataset(count);
                list.Add((Helper.GetEntityType(data), count, ObjectRunner.RunObject(data, QueryableExpressions.Client.Filtering.ChatGPT.FilterExtensions.ApplyFilter)));
                list.Add((Helper.GetEntityType(data), count, ObjectRunner.RunObject(data, QueryableExpressions.Client.Filtering.CoPilot.FilterExtensions.ApplyFilter)));
            }

            {
                var data = new List<Object4>();
                data.CreateDataset(count);
                list.Add((Helper.GetEntityType(data), count, ObjectRunner.RunObject(data, QueryableExpressions.Client.Filtering.ChatGPT.FilterExtensions.ApplyFilter)));
                list.Add((Helper.GetEntityType(data), count, ObjectRunner.RunObject(data, QueryableExpressions.Client.Filtering.CoPilot.FilterExtensions.ApplyFilter)));
            }

            {
                var data = new List<Object8>();
                data.CreateDataset(count);
                list.Add((Helper.GetEntityType(data), count, ObjectRunner.RunObject(data, QueryableExpressions.Client.Filtering.ChatGPT.FilterExtensions.ApplyFilter)));
                list.Add((Helper.GetEntityType(data), count, ObjectRunner.RunObject(data, QueryableExpressions.Client.Filtering.CoPilot.FilterExtensions.ApplyFilter)));
            }
        }

        foreach (var entry in list)
        {
            Console.WriteLine($"{entry.Type.Name} : {entry.Count} : {entry.Elapsed}");
        }
    }
}