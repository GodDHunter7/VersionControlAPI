using Microsoft.AspNetCore.Mvc;

namespace VersionControlAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NameController : ControllerBase
{
    [HttpGet]
    public IActionResult GetName()
    {
        return Ok(new
        {
            name = "Hunter Ward"
        });
    }
}
