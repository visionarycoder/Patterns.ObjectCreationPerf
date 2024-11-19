namespace ObjectCreation.Client;

public static class InstantiationFactory
{

    public static T New<T>() where T : new()
    {
        return new T();
    }

    public static T Activate<T>() where T : new()
    {
        return Activator.CreateInstance<T>();
    }

}