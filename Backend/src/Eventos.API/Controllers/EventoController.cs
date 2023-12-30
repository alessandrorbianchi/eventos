using Microsoft.AspNetCore.Mvc;

namespace Eventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public EventoController()
    {
    
    }

    [HttpGet]
    public string Get()
    {
        return "value";
    }
}
