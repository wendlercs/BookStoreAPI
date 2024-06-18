using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookStoreApiBaseController : ControllerBase
{
    [HttpGet("testapi")]
    protected IActionResult ApiTest()
    {
        return Ok("Api is working");
    }
}
