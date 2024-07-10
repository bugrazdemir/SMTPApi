using Microsoft.AspNetCore.Mvc;

namespace MailSMTP.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
