namespace StyleCop.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StyleCopExample.Application.Common;
using StyleCopExample.Application.DTOs.Order.Responses;
using StyleCopExample.Persistence.Contexts;
using StyleCopExample.Application.Mappers;

[Route("api/order")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly ApplicationDbContext _dbContext;

    public OrderController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    [ProducesResponseType(typeof(ApiResponse<OrderResponseDTO>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetFirstOrder()
    {
        var result = await _dbContext.Orders.FirstOrDefaultAsync();

        if (result is null)
        {
            return NotFound(ApiResponse<OrderResponseDTO>.Fail("Order not found", 404));
        }

        return Ok(ApiResponse<OrderResponseDTO>.Ok(result.ToResponseDTO()));
    }
}
