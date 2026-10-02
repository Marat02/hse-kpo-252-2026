using HSE.KPO.Domain.Models;

namespace HSE.KPO.Domain.Patterns;

public interface IPrototype
{
    IEngine Clone();
}