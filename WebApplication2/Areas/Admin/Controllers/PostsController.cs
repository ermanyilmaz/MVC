﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    public class PostsController: Controller
    {
        public ActionResult Index()
        {
            return Content("PostsController Inside of the Admin Area !");
        }
    }
}