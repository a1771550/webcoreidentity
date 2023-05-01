using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebCoreIdentity.Controllers
{
    [Authorize]
    public class ConfidentialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
