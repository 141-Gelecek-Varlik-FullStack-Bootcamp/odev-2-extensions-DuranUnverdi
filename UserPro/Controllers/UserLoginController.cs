using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserPro.Filters;
using UserPro.Models;

namespace UserPro.Controllers
{
    public class UserLoginController : Controller
    {
        ApplicationDbContext c = new ApplicationDbContext();

        public IActionResult Index()
        {
            return View();
        }
        [ActionFilter]
        [HttpPost]
        public async Task<IActionResult> Index(User p)
        {
            var dataValue = c.Users.FirstOrDefault(x => x.Email == p.Email && x.Password == p.Password);
            if (dataValue != null)
            {
                //var claims = new List<Claim>
                //{
                //    new Claim(ClaimTypes.Name,p.Email)
                //};
                //var userIdentity=new ClaimsIdentity(claims,)
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "UserRegister");
            }
        }
    }
}
