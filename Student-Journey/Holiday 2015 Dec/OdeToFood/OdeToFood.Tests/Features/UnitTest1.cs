﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OdeToFood.Models;
using System.Collections.Generic;

namespace OdeToFood.Tests.Features
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var data = new Restaurant();
            data.Reviews = new List<ResturantReview>();
            data.Reviews.Add(new ResturantReview() { Rating = 4 });

            var rater = new RestaurantRater(data);
            var result = rater.ComputeRating(10);

            Assert.AreEqual(4, result.Rating);
        }
    }
}
