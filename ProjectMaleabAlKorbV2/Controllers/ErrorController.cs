﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectMaleabAlKorbV2.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult NotFoundPage()
        {
            return View();
        }
    }
}