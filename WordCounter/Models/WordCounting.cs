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
        public bool matchExists(string userQueryWord, string[] sentenceArray)
        {
            if ((sentenceArray != null) & (sentenceArray.Length > 0))
            {
                foreach (string word in sentenceArray)
                {
                    if (word == userQueryWord)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public int matchCounter(string userQueryWord, string[] sentenceArray)
        {
            int matchCount = 0;
            if ((sentenceArray != null) & (sentenceArray.Length > 0))
            {
                foreach (string word in sentenceArray)
                {
                    if (word == userQueryWord)
                    {
                        matchCount += 1;
                    }
                }
                return matchCount;
            }
            return 0;
        }
    }
    public class Program
    {
        public static void Main()
        {
          Console.WriteLine("Please enter a sentence.");
          string sentence = Console.ReadLine();
          Console.WriteLine("Please enter the word you'd like to count.");
          string inputWord = Console.ReadLine();
          WordCounting userInputStrings = new WordCounting(inputWord, sentence);
          string[] userSentenceArray = userInputStrings.createSentenceArray(sentence);
          int result = userInputStrings.matchCounter(inputWord, userSentenceArray);
          Console.WriteLine(result);
        }
    }
}
