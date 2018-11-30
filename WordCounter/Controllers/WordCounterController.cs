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
            string[] sentenceArray = newCount.createSentenceArray(sentence);
            int result = newCount.matchCounter(word, sentenceArray);
            return View("Show", result);
        }
    }
}