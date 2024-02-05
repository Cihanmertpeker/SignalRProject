using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        [AllowAnonymous]

        public IActionResult Index()
        {
            return View();
        }
    }
}
