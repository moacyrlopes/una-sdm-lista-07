using Microsoft.AspNetCore.Mvc;

namespace EcoTrackApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SustentabilidadeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "API funcionando 🚀";
        }
    }
}