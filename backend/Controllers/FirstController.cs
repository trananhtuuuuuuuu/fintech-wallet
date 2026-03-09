using Microsoft.AspNetCore.Mvc;
namespace backend.Controllers;

[ApiController]
[Route("api/hello")]
public class FirstController : ControllerBase
{
  [HttpGet]
  public IActionResult GetFunction()
  {
    return Ok("Hello from The first Controller");
  }
}


