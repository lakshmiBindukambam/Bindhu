using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using LoginApplication.Models;

namespace LoginApplication.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginApplication.Models.login log)
        {
            LoginApplication.Models.LoginApp lapp = new Models.LoginApp();
            var userdetails = lapp.logins.Find(log.LoginID);
            if (userdetails != null)
            {
                if (log.Password == userdetails.Password)
                {

                    FormsAuthentication.SetAuthCookie(Convert.ToString(log.LoginID), true);
                    return RedirectToAction("Welcome");
                }
                else return View();
            }
            else
            {
                return View();
            }
        }

        public ActionResult Welcome()
        {
            return View();
        }
    }
}