﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class PostsController : Controller
    {
        public ActionResult Index()
        {
            //return Content("<h1 style='color: Red'>Hello, World!</h1>");
            return View();
        }
    }
}