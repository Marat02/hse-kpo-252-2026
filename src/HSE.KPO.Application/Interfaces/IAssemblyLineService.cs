using HSE.KPO.Domain.Models;

namespace HSE.KPO.Application.Interfaces;

public interface IAssemblyLineService
{
    public AssemblyLine Create()
    {
        return new AssemblyLine();
    }
}