using Microsoft.AspNetCore.Mvc;

namespace SkiaSharpWebApi.Controllers
{
    [Route("api/[controller]")]
    public class ColorTypeController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "unknown";
        }
    }
}
