using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CountingWords.Models;
using CountingWords.Controllers;

namespace CountingWords.Tests
{
    [TestClass]
    public class HomeControllerTest
    {

        [TestMethod]
        public void Index_HasCorrectModelType_ItemList()
        {
            ViewResult indexView = new HomeController().Index() as ViewResult;

            var result = indexView.ViewData.Model;

            Assert.IsInstanceOfType(result, typeof(int));
        }
    }
}