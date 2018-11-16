using System;
using System.Collections.Generic;

namespace WordCount
{
  public class WordCounter
  {
    //   Class Definition
      public string QueryWord;
      public string InputSentence;
      public List<string> InputSentenceList = new List<string>{};
    // Constructor
      public WordCounter(string queryWord, string inputSentence, List<string> inputSentenceList)
      {
          QueryWord = queryWord;
          InputSentence = inputSentence;
          InputSentenceList = inputSentenceList;

      }
  }
}