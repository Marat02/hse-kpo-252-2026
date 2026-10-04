namespace HSE.KPO.Domain.Models;

public enum AssemblyLineStatus
{
    Idle = 0,
    Ready = 1,
    Working = 2,
    Stopped = 3,
    Broken = 4,
    Maintenance = 5
}