namespace StyleCopExample.Domain.Entities;

public class Order
{
    public Guid Id { get; set; }

    required public string Name { get; set; }
}