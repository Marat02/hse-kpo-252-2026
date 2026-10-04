using HSE.KPO.Domain.Models;

namespace HSE.KPO.Domain.Patterns.Creative;

public interface ICarBuilder
{
    ICarBuilder SetId(int id);
    ICarBuilder SetWheels(IWheel[] wheels);
    ICarBuilder SetEngine(IEngine engine);
    ICar Build();
}