namespace HSE.KPO.DependencyInjector;

public class DependencyInjector
{
    private readonly Dictionary<Type, Func<DependencyInjector, object>> _registrations = new();
    
    public void Register<TClass>(Func<DependencyInjector, TClass> factory)
    {
        _registrations.Add(typeof(TClass), (di) => factory(di));
    }

    public TClass Create<TClass>()
    {
        return (TClass) _registrations[typeof(TClass)].Invoke(this);
    }
}