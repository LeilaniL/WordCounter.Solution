using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CountingWords.Models;

namespace CountingWords.Tests
{
    [TestClass]
    public class WordCountingTest
    {
        [TestMethod]
        public void WordCounting_CreatesArrayOfWords_Array()
        {
            WordCounting testWordCount = new WordCounting("testQueryWord", "this is a test sentence");
            string[] testSentenceArray = { "this", "is", "a", "test", "sentence" };
            CollectionAssert.AreEqual(testSentenceArray, testWordCount.ArrayFromSentence);
        }

        [TestMethod]
        public void WordCounting_CountsWordMatches_Int()
        {
            WordCounting testWordCount = new WordCounting("love", "I love love C Sharp");
            Assert.AreEqual(2, testWordCount.matchCounter(testWordCount.QueryWord, testWordCount.ArrayFromSentence));
        }
        [TestMethod]
        public void WordCounting_IgnoresCase_Int()
        {
            WordCounting testWordCount = new WordCounting("love", "I love love LOVE C Sharp");
            Assert.AreEqual(3, testWordCount.matchCounter(testWordCount.QueryWord, testWordCount.ArrayFromSentence));
        }
        [TestMethod]
        public void WordCounting_SaysNoMatches_Int()
        {
            WordCounting testWordCount = new WordCounting("hate", "I love love LOVE C Sharp");
            Assert.AreEqual(0, testWordCount.matchCounter(testWordCount.QueryWord, testWordCount.ArrayFromSentence));
        }
    }
}
