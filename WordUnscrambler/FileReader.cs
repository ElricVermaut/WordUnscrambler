<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class FileReader
    {
        public string[] Read(string filename)
        {            
            StreamReader sr = new StreamReader(filename);
            List<string> words = new List<string>();
            string word;
            while ((word = sr.ReadLine()) != null)
            {
                words.Add(word);
            }
            string[] wordsArray = words.ToArray();
            return wordsArray;

        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class FileReader
    {
        public string[] Read(string filename)
        {            
            StreamReader sr = new StreamReader(filename);
            List<string> words = new List<string>();
            string word;
            while ((word = sr.ReadLine()) != null)
            {
                words.Add(word);
            }
            string[] wordsArray = words.ToArray();
            return wordsArray;

        }
    }
}
>>>>>>> 19f60c15a6475b003b2225e54713eec60f364a38
