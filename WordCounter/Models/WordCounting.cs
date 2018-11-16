using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class WordCounting
  {
    //   Class Definition
      public string QueryWord;
      public string InputSentence;
      public List<string> InputSentenceList = new List<string>{};
   
    // Constructor
      public WordCounting(string queryWord, string inputSentence, List<string> inputSentenceList)
      {
          QueryWord = queryWord;
          InputSentence = inputSentence;
          InputSentenceList = inputSentenceList;

      }
      public bool objectExists(string testString)
      {
        return true;
      }
  }
}