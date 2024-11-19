using Shared.Objects.Models;

namespace Shared;

public static class ObjectFactory
{

    private static readonly Random random = new Random();

    public static void CreateDataset(this List<Object2> list, int count)
    {
        list.Clear();
        list.AddRange(Enumerable.Range(1, count).Select(_ => new Object2(id: random.Next(1, 1000), name: CharacterFactory.GenerateRandomString(10))).ToList());
    }

    public static void CreateDataset(this List<Object4> list, int count)
    {
        list.Clear();
        list.AddRange(Enumerable.Range(1, count).Select(_ => new Object4(id: random.Next(1, 1000), name: CharacterFactory.GenerateRandomString(10), price: new decimal(random.Next(1, 1000)), created: DateTime.Now.AddDays(-random.Next(1, 1000)))).ToList());
    }

    public static void CreateDataset(this List<Object8> list, int count)
    {
        list.Clear();
        list.AddRange(Enumerable.Range(1, count).Select(_ => new Object8(id: random.Next(1, 1000), name: CharacterFactory.GenerateRandomString(10), price: new decimal(random.Next(1, 1000)), created: DateTime.Now.AddDays(-random.Next(1, 1000)), isActive: random.Next(0, 2) == 1, description: CharacterFactory.GenerateRandomString(20), category: CharacterFactory.GenerateRandomString(10), stock: random.Next(1, 1000))).ToList());
    }

}