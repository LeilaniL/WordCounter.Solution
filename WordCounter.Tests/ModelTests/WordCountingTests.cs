using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCountingTest
  {
    [TestMethod]
    public void WordCount_WordCountConstructsObject_WordCount()
    {
        WordCounting testWordCount = new WordCounting("testQueryWord", "this is a test sentence");
        string[] testSentenceArray = {"this","is","a","test","sentence"};
        CollectionAssert.AreEqual(testSentenceArray, testWordCount.createSentenceArray(testWordCount.InputSentence));

    }
  }
}