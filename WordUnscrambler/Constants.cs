using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordUnscrambler
{
    static class Constants
    {
        public const string question = "Enter scrambled word(s) manually or as a file: F - file / M - manual";
        public const string option = "String is empty";
        public const string fileAsk = "Enter full path including the file name: ";
        public const string manualAsk = "Enter wird(s) manually (seperated by commas if multiple): ";
        public const string errorAsk = "The entered option was not recognized.";
        public const string error = "The program will be terminated.";
        public const string retry = "Would you like to retry? Y/N";
        public const string retryOther = "Would you like to try again with other words? Y/N";
    }
}