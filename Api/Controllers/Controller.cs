using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Controller(ILogger<Controller> logger) : ControllerBase
    {
      
    }
}
