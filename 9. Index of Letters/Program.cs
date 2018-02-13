using System;
using System.Linq;

namespace _9._Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = new char[26];
            string word = Console.ReadLine();
        
            for (int i = 0; i <letters.Length; i++)
            {
                letters[i] = (char)('a'+i);
               
            }
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i] + " -> "+Array.IndexOf(letters,word[i]));
            {

            }
            }

        }
    }
}
