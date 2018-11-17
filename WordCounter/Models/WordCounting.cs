using System;
using System.Collections.Generic;

namespace WordCounter
{
  public class WordCounting
  {
    //   Class Definition
      public string QueryWord;
      public string InputSentence;

    // Constructor
      public WordCounting(string queryWord, string inputSentence)
      {
          QueryWord = queryWord;
          InputSentence = inputSentence;

      }
      public string[] createSentenceArray(string userInput)
      {
        string[] sentenceArray = InputSentence.Split(' ');
        // Console.WriteLine(sentenceArray);
        return sentenceArray;
      }
  }
}