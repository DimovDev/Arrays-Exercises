using System;
using System.Linq;

namespace _07._Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int countmax = 0;
            int startmax = 0;
            int count = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                count = 0;
                while (array[i + count] < array[i + 1 + count])
                {
                    count++;
                    if (i + 1 + count > array.Length - 1)
                    {
                        break;
                    }
                }
                if (count > countmax)
                {
                    countmax = count;
                    startmax = i;
                }
            }
            for (int i = startmax; i <= startmax + countmax; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
    }
}
