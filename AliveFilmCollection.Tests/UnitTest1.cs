using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AliveFilmCollection.Controllers;
using System.Web.Mvc;

namespace AliveFilmCollection.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddFilmsReturnsView()
        {
            var homecontroller = new UserFilmsController();
            var result = homecontroller.AddFilms() as ViewResult;
            Assert.AreEqual("AddFilms", result.ViewName);
        }
    }
}
