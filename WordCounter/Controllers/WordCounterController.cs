using Microsoft.AspNetCore.Mvc;
using CountingWords.Models;

namespace CountingWords.Controllers
{
    public class WordCounterController : Controller
    {
        [HttpGet("/new")]
        public ActionResult New()
        {
            return View();
        }
        [HttpPost("/searchResults")]
        public ActionResult Create(string word, string sentence)
        {
            WordCounting newCount = new WordCounting(word, sentence);
            return View("Show", newCount);
        }
        // [HttpGet("/searchResults")]
        // public ActionResult Show()
    }
}