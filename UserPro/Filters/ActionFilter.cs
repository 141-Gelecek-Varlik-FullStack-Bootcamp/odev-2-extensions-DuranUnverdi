using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using UserPro.Models;

namespace UserPro.Filters
{
    public class ActionFilter : Attribute, IActionFilter
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public void OnActionExecuted(ActionExecutedContext context)
        {
    
            db.Logs.Add(new Log()
            {
                ControllerName = "Çıkış Yapıldı",
                Date = DateTime.Now
            }); ;
            db.SaveChanges();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            db.Logs.Add(new Log()
            {
                ControllerName = "Giriş Yapıldı",
                Date = DateTime.Now
            }); ;
            db.SaveChanges();
        }
    }
}
