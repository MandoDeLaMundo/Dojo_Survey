using Microsoft.AspNetCore.Mvc;
namespace Dojo_Survey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("result")]
        public IActionResult Result(string NameField, string DojoField, string LanguageField, string CommentField)
        {
            ViewBag.NameField = NameField;
            ViewBag.DojoField = DojoField;
            ViewBag.LanguageField = LanguageField;
            ViewBag.CommentField = CommentField;
            return View();
        }
    }
}