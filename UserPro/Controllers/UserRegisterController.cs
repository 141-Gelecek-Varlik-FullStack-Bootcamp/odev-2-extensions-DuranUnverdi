using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserPro.Models;

namespace UserPro.Controllers
{
    public class UserRegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View(new User());
        }
        [HttpPost]
        public IActionResult Add(User p)
        {
            ApplicationDbContext c = new ApplicationDbContext();
           
            c.Users.Add(p);
            c.SaveChanges();
            //c.Add(new User
            //{
            //    Name = p.Name,
            //    SurName=p.SurName,
            //    Email=p.Email,
            //    Password=p.Password
            //});                     
                return RedirectToAction("Index", "UserLogin");
           
          

        }
    }
}
