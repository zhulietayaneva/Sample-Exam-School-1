using System;
using System.Collections.Generic;
using System.Linq;

namespace WordsEx
{
     class Word
    {
        public string word { get; private set; }

        public bool isValid => word.Length > 0 && word == word.ToUpper();

        public Word(string value)
        {
            this.word = value;
        }

        public bool IsSinging => HasTwoConsecutiveConsonants();

        private bool HasTwoConsecutiveConsonants()
        {

            for (int i = 0; i < word.Length - 1; i++)
            {
                if ("AEIOU".IndexOf(word[i]) < 0 && "AEIOU".IndexOf(word[i + 1]) < 0)
                {
                    return false;
                }
            }

            return true;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Word> wordsList = new List<Word>();
            string input = Console.ReadLine();

            while (input!= String.Empty)
            {
                var currWord = new Word(input);
                if (currWord.isValid && !wordsList.Select(w=>w.word).Any(w=>w==currWord.word))
                {
                    wordsList.Add(currWord);
                }

               input = Console.ReadLine();
            }

            var wordsListOrdered = wordsList.OrderByDescending(w => w.IsSinging)
             .ThenBy(w => w.word)
             .ThenByDescending(w => w.word.Length)
             .ThenBy(w=>w.word);

            Console.WriteLine(String.Join("\n", wordsListOrdered.Select(w=>w.word)));
        }
    }
}
