using Shared.Data.Models;

namespace Shared;

public static class EntityFactory
{

    private static readonly Random random = new();

    public static void CreateDataset(this List<Entity2> list, int count)
    {
        list.Clear();
        for (var i = 0; i < count; i++)
        {
            list.Add(new Entity2(id: random.Next(0,1000), name: CharacterFactory.GenerateRandomString(10)));
        }
    }

    public static void CreateDataset(this List<Entity4> list, int count)
    {
        list.Clear();
        for (var i = 0; i < count; i++)
        {
            list.Add(new Entity4(id: random.Next(0, 1000), name: CharacterFactory.GenerateRandomString(10), price: new decimal(random.Next(1, 1000)), created: DateTime.Now.AddDays(-random.Next(1, 1000))));
        }
    }

    public static void CreateDataset(this List<Entity8> list, int count)
    {
        list.Clear();
        for (var i = 0; i < count; i++)
        {
            list.Add(new Entity8(id: random.Next(0, 1000), name: CharacterFactory.GenerateRandomString(10), price: new decimal(random.Next(1, 1000)), created: DateTime.Now.AddDays(-random.Next(1, 1000)), isActive: random.Next(0, 2) == 1, description: CharacterFactory.GenerateRandomString(20), category: CharacterFactory.GenerateRandomString(10), stock: random.Next(1, 1000)));
        }
    }

}

