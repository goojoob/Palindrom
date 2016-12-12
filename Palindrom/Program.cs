using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {

        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Input text to test if is Palindrom:");
            text = Console.ReadLine();

            Word wordToTest = new Word(text);

            if (wordToTest.isPalindrom())
            {
                Console.WriteLine("\n{0} is Palindrom!",text);
            }
            else
            {
                Console.WriteLine("\n{0} is not Palindrom :(", text);
            }
            
            Console.ReadLine();
        }
    }
}
