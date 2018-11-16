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
       List<string> testList = new List<string> {"example", "list"};
        WordCounting testWordCount = new WordCounting("testQueryWord", "this is a test sentence", testList);
        Assert.AreEqual(true, testWordCount.objectExists("example"));

    }
  }
}