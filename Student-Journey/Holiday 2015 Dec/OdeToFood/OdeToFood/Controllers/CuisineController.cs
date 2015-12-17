﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
       
        public ActionResult Search(string name = "French")
        {
           
            var message = Server.HtmlEncode(name);
            //return Json(new { Message = message, Name = "Lincoln" }, JsonRequestBehavior.AllowGet);
            //return File(Server.MapPath("~/Content/Site.css"), "text/css");
            return Content(message);

        }
    }
}