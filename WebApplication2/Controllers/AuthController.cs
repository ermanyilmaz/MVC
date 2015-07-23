using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class AuthController : Controller
    {

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("home");
        }
        // GET: Auth
        public ActionResult Login()
        {
            return View(new AuthLogin { });
        }
        [HttpPost]
        public ActionResult Login(AuthLogin form, string returnUrl)
        {
           if(!ModelState.IsValid)
            return View(form);
            // this is the authentication which determines if a person is who says he is.
           FormsAuthentication.SetAuthCookie(form.Username, true); // All the encryption and hashing and validation is made by asp.net

           if (!string.IsNullOrWhiteSpace(returnUrl))
               return Redirect(returnUrl);

           return RedirectToRoute("home");

        }
    }
}