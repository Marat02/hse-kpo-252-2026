namespace HSE.KPO.Sales.Domain;

public class Bill
{
    public int Id { get; }
    public int ClientId { get; }
    public int CarId { get; }
    public DateTime Date { get; }
    public decimal Price { get; }
}