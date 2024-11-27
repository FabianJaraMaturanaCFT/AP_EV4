using Microsoft.AspNetCore.Mvc;

namespace AP_EV4.Controllers
{
    public class EmpleadoHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
