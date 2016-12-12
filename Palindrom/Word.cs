using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Word
    {
        string word;

        public Word(string text)
        {
            word = removeCaseSensitive(removeBlanks(text));
        }

        private string removeBlanks(string text)
        {
            return text.Replace(" ", "");
        }

        private string removeCaseSensitive(string text)
        {
            return text.ToUpper();
        }


        public bool isPalindrom()
        {
            int endPosition = word.Length - 1;
            int initPosition = 0;

            while (initPosition < endPosition)
            {
                if (word[initPosition] != word[endPosition])
                {
                    return false;
                }
                initPosition++;
                endPosition--;
            }

            return true;
        }
    }
}
