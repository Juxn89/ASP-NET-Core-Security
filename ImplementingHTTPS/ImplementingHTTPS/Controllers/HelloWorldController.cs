using Microsoft.AspNetCore.Mvc;

namespace ImplementingHTTPS.Controllers
{
    [RequireHttps]
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
