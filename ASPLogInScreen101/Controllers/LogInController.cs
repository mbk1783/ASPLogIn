using ASPLogInScreen101.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPLogInScreen101.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        public ActionResult Index()
        {
            return View("LogInView");
        }

        [HttpPost]
        public ActionResult Login(LogInModel model)
        {
            if (model.Username == "admin" && model.Password == "admin")
            {
                return RedirectToAction("Index", "Main");
            }

            ViewBag.Error = "Geçersiz kullanıcı adı veya şifre!";
            return View("LogInView");
        }
    }
}