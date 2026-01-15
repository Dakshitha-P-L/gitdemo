using Microsoft.AspNetCore.Mvc;

namespace gitdemo.Models
{
    public class demo : Controller
    {
        public IActionResult Index()
        {
            // hi, how you doing?
            return View();
        }
    }
}
