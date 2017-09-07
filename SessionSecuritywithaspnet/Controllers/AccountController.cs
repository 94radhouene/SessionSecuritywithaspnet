using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SessionSecuritywithaspnet.ViewModel;
using SessionSecuritywithaspnet.Models;
using SessionSecuritywithaspnet.Security;

namespace SessionSecuritywithaspnet.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Accountviewmodel accview)
        {
            AccountModel accmo = new AccountModel();
            if (string.IsNullOrEmpty(accview.acount.username) || string.IsNullOrEmpty(accview.acount.Password)
                || accmo.login(accview.acount.username, accview.acount.Password) == null)
            {
                ViewBag.error = "Account's Invalid";
                return View("Index");
            }
            SessionPersister.username = accview.acount.username;
            return View("../Demo/Work1");

        }
        public ActionResult Logout()
        {
            SessionPersister.username = string.Empty;
            return RedirectToAction("Index");
        }
    }
}