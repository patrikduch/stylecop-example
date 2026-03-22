namespace StyleCopExample.Application.DTOs.Order.Responses;

public class OrderResponseDTO
{
    public Guid Id { get; set; }

    required public string Name { get; set; }
}
