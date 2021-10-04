<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class WordMatcher
    {
        public List<MatchedWord> Match(string[] scrambledWords, string[] wordList)
        {
            List<MatchedWord> matchedWords = new List<MatchedWord>();
         
            foreach (var scrambledWord in scrambledWords)
            {
                foreach (var word in wordList)
                {
                    
                    char[] scrambledWordArray = scrambledWord.ToArray();
                    char[] wordArray = word.ToArray();

                    Array.Sort(wordArray);
                    Array.Sort(scrambledWordArray);

                    string sortedScrambledWord = new string(scrambledWordArray);
                    string sortedWord = new string(wordArray);

                    if (sortedScrambledWord.Equals(sortedWord, StringComparison.OrdinalIgnoreCase)) {
                        matchedWords.Add(BuildMatchedWord(scrambledWord, word));
                        Console.WriteLine("MATCH FOUND FOR {0}: {1}", scrambledWord, word);
                    }
                }
            }

            MatchedWord BuildMatchedWord(string scrambledWord, string word)
            {
                MatchedWord matchedWord = new MatchedWord
                {
                    ScrambledWord = scrambledWord,
                    Word = word
                };

                return matchedWord;
            }

            return matchedWords;
        }
        
    }

}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class WordMatcher
    {
        public List<MatchedWord> Match(string[] scrambledWords, string[] wordList)
        {
            List<MatchedWord> matchedWords = new List<MatchedWord>();
         
            foreach (var scrambledWord in scrambledWords)
            {
                foreach (var word in wordList)
                {
                    
                    char[] scrambledWordArray = scrambledWord.ToArray();
                    char[] wordArray = word.ToArray();

                    Array.Sort(wordArray);
                    Array.Sort(scrambledWordArray);

                    string sortedScrambledWord = new string(scrambledWordArray);
                    string sortedWord = new string(wordArray);

                    if (sortedScrambledWord.Equals(sortedWord, StringComparison.OrdinalIgnoreCase)) {
                        matchedWords.Add(BuildMatchedWord(scrambledWord, word));
                        Console.WriteLine("MATCH FOUND FOR {0}: {1}", scrambledWord, word);
                    }
                }
            }

            MatchedWord BuildMatchedWord(string scrambledWord, string word)
            {
                MatchedWord matchedWord = new MatchedWord
                {
                    ScrambledWord = scrambledWord,
                    Word = word
                };

                return matchedWord;
            }

            return matchedWords;
        }
        
    }

}
>>>>>>> 19f60c15a6475b003b2225e54713eec60f364a38
