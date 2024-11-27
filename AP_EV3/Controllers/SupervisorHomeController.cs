using Microsoft.AspNetCore.Mvc;

namespace AP_EV4.Controllers
{
    public class SupervisorHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
