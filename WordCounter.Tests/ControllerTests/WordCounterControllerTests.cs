using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CountingWords.Models;
using CountingWords.Controllers;

namespace CountingWords.Tests
{
    [TestClass]
    public class WordCounterControllerTests
    {
        [TestMethod]
        public void Create_ReturnsCorrectView_Show()
        {
            //Arrange
            WordCounterController controller = new WordCounterController();

            //Act
            ActionResult showView = controller.Create("test", "this is for testing");

            //Assert
            Assert.IsInstanceOfType(showView, typeof(ViewResult));
        }

        [TestMethod]
        public void Create_CreatesCorrectModelType_WordCounting()
        {
            string countWord = "lots";
            ViewResult createView = new WordCounterController().Create(countWord, "there are lots and lots of cats on the internet") as ViewResult;

            var result = createView.ViewData.Model;

            Assert.IsInstanceOfType(result, typeof(WordCounting));
        }
    }
}