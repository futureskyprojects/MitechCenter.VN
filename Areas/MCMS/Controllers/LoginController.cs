
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MitechCenter.vn.Areas.MCMS.Models;
using MitechCenter.vn.Models;
using MitechCenter.vn.Models.DataManager;
using MitechCenter.vn.Models.Repository;

namespace MitechCenter.vn.Areas.MCMS.Controllers
{
    [Area("MCMS")]
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager _context;
        public LoginController(IDataRepository<User> context)
        {
            this._context = (UserManager)context;
        }
        public IActionResult Index()
        {
            ViewBag.notification = TempData["ERROR"];
            return View(new User());
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            var foundUser = _context.Find(user.username.ToLower(), user.encryptPassword);
            if (foundUser == null)
            {
                TempData["ERROR"] = Notification.Error("LỖI", "Sai tài khoản hoặc mật khẩu!");
                return RedirectToAction("Index");
            }
            else
            {
                var claims = new List<Claim>
                {
                    new Claim("ID", foundUser.uId.ToString()),
                    new Claim(ClaimTypes.Name, foundUser.displayName),
                    new Claim(ClaimTypes.Role, foundUser.role.ToString()),
                    new Claim("AVATAR", foundUser.avatar == null?"":foundUser.avatar)
                };
                var identify = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme
                );
                var principal = new ClaimsPrincipal(identify);
                var props = new AuthenticationProperties();
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props).Wait();

            }
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(
                scheme: CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }
    }
}