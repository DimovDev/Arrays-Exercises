using System;
using System.Linq;

namespace _9._Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        { 
            char[] letters = new char[600];
            string[] word = Console.ReadLine().Split().ToArray();
        
            for (char i = 'a'; i <= 'z'; i++)
            {
                letters[i] = new char[letters[i]];
               
            }
            for (int i = 0; i < letters.Length; i++)
            {
                if(letters[i])==word[i])
            {

            }
            }

        }
    }
}
