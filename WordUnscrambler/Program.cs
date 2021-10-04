using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace WordUnscrambler
{
    class Program
    {
        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();
        private static bool retry;

        static void Main(string[] args)
        {

            retry = true;
            while (retry == true)
            {
                try
                {
                    Console.WriteLine(Constants.question);


                    var option = Console.ReadLine() ?? throw new Exception(Constants.option);

                    switch (option.ToUpper())
                    {
                        case "F":
                            Console.WriteLine(Constants.fileAsk);
                            ExecuteScrambledWordsInFileScenario();
                            break;
                        case "M":
                            Console.WriteLine(Constants.manualAsk);
                            ExecuteScrambledWordsManualEntryScenario();
                            ManualWordRetry();
                            break;
                        default:
                            Console.WriteLine(Constants.errorAsk);
                            break;
                    }



                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(Constants.error + ex.Message);

                }
                Retry();
            }
        }
        private static void ExecuteScrambledWordsInFileScenario()
        {
            var filename = Console.ReadLine();
            string[] scrambledWords = _fileReader.Read(filename);
            DisplayMatchedUnscrambledWords(scrambledWords);
        }

        private static void ExecuteScrambledWordsManualEntryScenario()
        {
            string scrambledWords = Console.ReadLine();
            string noSpaceScrambledWords = scrambledWords.Replace(" ", "");
            string[] arrayedScrambledWords = noSpaceScrambledWords.Split(',');
            DisplayMatchedUnscrambledWords(arrayedScrambledWords);
        }

        private static void DisplayMatchedUnscrambledWords(string[] scrambledWords)
        {
            //read the list of words from the system file. 
            string[] wordList = _fileReader.Read("wordlist.txt");

            //call a word matcher method to get a list of structs of matched words.
            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords, wordList);
        }
        private static void Retry()
        {
            Console.WriteLine(Constants.retry);
            string ask = Console.ReadLine();
            switch (ask.ToUpper())
            {
                case "Y":
                    retry = true;
                    break;
                case "N":
                    retry = false;
                    break;
                default:
                    Retry();
                    break;
            }
        }
        private static void ManualWordRetry()
        {
            Console.WriteLine(Constants.retryOther);
            string ask = Console.ReadLine().ToUpper();
            if (ask == "Y")
            {
                Console.WriteLine(Constants.manualAsk);
                ExecuteScrambledWordsManualEntryScenario();
                ManualWordRetry();
            }
        }
    }
}
