namespace HSE.KPO.Domain.Models;

public class Engine : IEngine
{
    private readonly int _id;

    public Engine(int id)
    {
        _id = id;
    }

    public object Clone()
    {
        return new Engine(_id);
    }
}