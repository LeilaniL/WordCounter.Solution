using System;
using System.Collections.Generic;

namespace CountingWords.Models
{
    public class WordCounting
    {
        //   Class Definition
        public string QueryWord;
        public string InputSentence;
        public string[] ArrayFromSentence;

        // Constructor
        public WordCounting(string queryWord, string inputSentence)
        {
            QueryWord = queryWord;
            InputSentence = inputSentence;
            ArrayFromSentence = inputSentence.Split(' ');
        }
        // public string[] createSentenceArray(string userInput)
        // {
        //     string[] sentenceArray = InputSentence.Split(' ');
        //     // Console.WriteLine(sentenceArray);
        //     return sentenceArray;
        // }

        public int matchCounter(string userQueryWord, string[] sentenceArray)
        {
            string lowerCaseUserQuery = userQueryWord.ToLower();
            int matchCount = 0;
            if ((sentenceArray != null) & (sentenceArray.Length > 0))
            {
                foreach (string word in sentenceArray)
                {
                    string lowerCaseWord = word.ToLower();
                    if (lowerCaseWord == lowerCaseUserQuery)
                    {
                        matchCount += 1;
                    }
                }
                return matchCount;
            }
            return 0;
        }
    }
}
