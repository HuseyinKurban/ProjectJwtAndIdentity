using Microsoft.AspNetCore.Mvc;
using ProjectJwtAndIdentity.JWTTools;
using ProjectJwtAndIdentity.Models;

namespace ProjectJwtAndIdentity.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ResultAppUser resultAppUser)
        {
            var value = JwtTokenGenerator.GenerateToken(resultAppUser);
            ViewBag.v = value.Token;
            return View();
        }

    }
}
