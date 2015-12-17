﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class RestaurantsController : Controller
    {
        private OdeToFoodDb db = new OdeToFoodDb();

        // GET: Restaurants
        public ActionResult Index()
        {
            return View(db.Restaurants.ToList());
        }


    }
}
