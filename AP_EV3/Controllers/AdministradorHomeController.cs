using Microsoft.AspNetCore.Mvc;

namespace AP_EV4.Controllers
{
    public class AdministradorHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
