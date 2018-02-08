using System;
using System.Linq;

namespace _9._Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        { 
            string[] letters = new string[600];
            string[] word = Console.ReadLine().Split().Select(string.Parse).ToArray();
        
            for (char i = 'a'; i <= 'z'; i++)
            {
                letters[i] = (char)(i).ToString;
               
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
