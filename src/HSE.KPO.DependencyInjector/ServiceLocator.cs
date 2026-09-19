namespace HSE.KPO.DependencyInjector;

public static class ServiceLocator
{
    private static Dictionary<Type, Func<object>> _registrations = new();
    
    public static void Register<TClass>(Func<TClass> factory)
    {
        _registrations.Add(typeof(TClass), () => factory());
    }
    
    public static TClass Create<TClass>()
    {
        return (TClass) _registrations[typeof(TClass)].Invoke();
    }
}