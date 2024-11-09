namespace StyleCop.Controllers;

using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    [HttpGet]
    public IActionResult GetOrders()
    {
        return Ok("a");
    }
}
