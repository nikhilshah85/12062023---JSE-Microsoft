using Microsoft.AspNetCore.Mvc;

namespace apiCalls.Controllers
{
    public class ExternalDataController : Controller
    {
        public IActionResult PostData()
        {
            return View();
        }

        public IActionResult UserDetails()
        {
            return View();
        }
    }
}
