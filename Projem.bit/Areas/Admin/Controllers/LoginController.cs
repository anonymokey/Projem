using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Projem.Entities;
using Projem.Service.Abstract;
using System.Security.Claims;

namespace Projem.bit.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly IService<Kullanici> _service;

        public LoginController(IService<Kullanici> service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> LogoutAsync()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/Admin/Login");
        }

        [HttpPost]
        public async Task<IActionResult> IndexAsync(string email, string password)
        {
            try
            {
                // k = users
                var account = _service.Get(k => k.Email == email && k.Sifre == password && k.AktifMi == true);
                if (account == null)
                {
                    TempData["Mesaj"] = "Hatalı Giriş!";
                }
                else
                {
                    var claims = new List<Claim>()
                    {
                        new(ClaimTypes.Name, account.Adi),
                        new("Role", "Admin")
                    };
                    var userIdentity = new ClaimsIdentity(claims, "Login");
                    ClaimsPrincipal principal = new(userIdentity);
                    await HttpContext.SignInAsync(principal);
                    return Redirect("/Admin");
                }
            }
            catch (Exception)
            {
                TempData["Mesaj"] = "Hata!";
            }
            return View();
        }
    }
}