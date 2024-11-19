using System.Diagnostics;

namespace Shared;

public static class Helper
{

    public static Type GetEntityType<T>(List<T> data)
    {
        return data.GetType().GetGenericArguments()[0];
    }

}