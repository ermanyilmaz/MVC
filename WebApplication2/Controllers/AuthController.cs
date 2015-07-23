using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
           if(!ModelState.IsValid)
            return View(form);

           if (form.Username != "quarizma")
           {
               ModelState.AddModelError("Username", "Go and fun yourself !");
               return View(form);
           }

           return Content("The form is valid!");
        }
    }
}