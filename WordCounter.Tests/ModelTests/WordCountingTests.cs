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
    public void WordCounting_CountsWordMatches_Int()
    {
        WordCounting testWordCount = new WordCounting("love", "I love love C Sharp");
        Assert.AreEqual(2, testWordCount.matchCounter("love", new string[]{"I","love","love","C","Sharp"}));
    }
    [TestMethod]
    public void WordCounting_IgnoresCase_Int()
    {
        WordCounting testWordCount = new WordCounting("love", "I love love LOVE C Sharp");
        Assert.AreEqual(3, testWordCount.matchCounter("love", new string[]{"I","love","love","LOVE","C","Sharp"}));
    }
    [TestMethod]
    public void WordCounting_SaysNoMatches_String()
    {
        WordCounting testWordCount = new WordCounting("hate", "I love love LOVE C Sharp");
        Assert.AreEqual(0, testWordCount.matchCounter("hate", new string[]{"I","love","love","LOVE","C","Sharp"}));
    }
  }
}
