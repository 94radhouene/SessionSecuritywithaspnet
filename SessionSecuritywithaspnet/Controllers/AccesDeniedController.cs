﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionSecuritywithaspnet.Controllers
{
    public class AccesDeniedController : Controller
    {
        // GET: AccesDenied
        public ActionResult Index()
        {
            return View();
        }
    }
}