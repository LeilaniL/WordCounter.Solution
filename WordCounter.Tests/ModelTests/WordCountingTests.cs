using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCountingTest
  {
    [TestMethod]
    public void WordCounting_CreatesArrayOfWords_Array()
    {
        WordCounting testWordCount = new WordCounting("testQueryWord", "this is a test sentence");
        string[] testSentenceArray = {"this","is","a","test","sentence"};
        CollectionAssert.AreEqual(testSentenceArray, testWordCount.createSentenceArray(testWordCount.InputSentence));
    }
    [TestMethod]
    public void WordCounting_FindsMatchingWord_True()
    {
        WordCounting testWordCount = new WordCounting("love", "I love C Sharp");
        Assert.AreEqual(true, testWordCount.matchExists("love", new string[]{"I","love","C","Sharp"}));
    }
  }
}