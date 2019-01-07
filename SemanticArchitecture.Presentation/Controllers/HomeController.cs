using Microsoft.AspNetCore.Mvc;
using SemanticArchitecture.Presentation.Models;
using System.Diagnostics;

namespace SemanticArchitecture.Presentation.Controllers
{
    public class HomeController : Controller
    {
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}