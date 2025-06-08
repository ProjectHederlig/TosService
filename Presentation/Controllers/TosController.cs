using Microsoft.AspNetCore.Mvc;
using Presentation.Services;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TosController(TosServices tosServices) : ControllerBase
    {
    private readonly Services.TosServices _tosServices = tosServices;

    [HttpGet]
    public async Task<IActionResult> GetAll()
        {
        var result = await _tosServices.GetAllAsync();
        return Ok(result);
        }
    }

