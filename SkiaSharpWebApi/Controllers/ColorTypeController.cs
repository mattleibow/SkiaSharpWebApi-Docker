using Microsoft.AspNetCore.Mvc;
using SkiaSharp;

namespace SkiaSharpWebApi.Controllers
{
    [Route("api/[controller]")]
    public class ColorTypeController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return SKImageInfo.PlatformColorType.ToString().ToLowerInvariant();
        }
    }
}
