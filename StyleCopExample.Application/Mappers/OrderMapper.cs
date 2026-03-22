namespace StyleCopExample.Application.Mappers;

using StyleCopExample.Application.DTOs.Order.Responses;
using StyleCopExample.Domain.Entities;

public static class OrderMapper
{
    public static OrderResponseDTO ToResponseDTO(this Order order) =>
        new OrderResponseDTO
        {
            Id = order.Id,
            Name = order.Name,
        };

    public static List<OrderResponseDTO> ToResponseDTOList(this IEnumerable<Order> orders) =>
        orders.Select(o => o.ToResponseDTO()).ToList();
}
