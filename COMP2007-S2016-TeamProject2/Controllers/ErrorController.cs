﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP2007_S2016_TeamProject2.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult NotFound()
        {
            Response.StatusCode = 404;
            return View("NotFound");
        }
    }
}