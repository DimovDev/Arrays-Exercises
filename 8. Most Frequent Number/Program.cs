using System;
using System.Linq;

namespace _8._Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            // int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] A = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int count = 1;
            int currentIndex = 0;
            int most = 0;
            var mostFreq = 0;
            
            for (int i = A.Length - 1; i > 0; i--)
            {
                if (A[i] == A[currentIndex])
                {
                    count++;
                    most = A[currentIndex];
                }
                else
                    count--;
                if (count == 0)
                    //{
                    currentIndex = i;
             mostFreq = A[currentIndex];

            }


            Console.WriteLine(mostFreq);
        }
    }
}
