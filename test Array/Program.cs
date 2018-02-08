using System;
using System.Linq;

namespace test_Array
{
    class Program
    {
        static void Main(string[] args)
        {
           // ushort[] array = Console.ReadLine().Split(' ').Select(ushort.Parse).ToArray();
            int[] array = new int[] { 1, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

            int[] count = new int[array.Length];

            foreach (ushort num in array)
            {
                count[num]++;
            }

            int maxValue = count.Max();

            for (int i = 0; i < array.Length; i++)
            {
                if (count[array[i]] == maxValue)
                {
                    Console.WriteLine(array[i]);
                    return;
                }
            }
        }
    }
}
