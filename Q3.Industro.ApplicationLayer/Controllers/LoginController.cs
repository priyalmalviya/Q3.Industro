using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Q3.Industro.ApplicationLayer.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult LoginIndex()
        {
            return View();
        }
        [HttpPost]
       public JsonResult ValidateUser(string username, string password)
        {

            Session["Username"] = username;
            Session["Password"] = password;

            return Json(new { isSuccess = true }, JsonRequestBehavior.AllowGet);

        }
        public ActionResult LogOut()
        {
            Session.Abandon();
            Session.RemoveAll();
            return RedirectToAction("Index","Home");
        }
    }
}