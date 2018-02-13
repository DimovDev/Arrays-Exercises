using System;
using System.Linq;

namespace _11._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] numbers =Console.ReadLine().Split(' ').Select(int.Parse). ToArray();
          //int[] numbers = new int [] { 1,2,3,3 };
            int leftSum = 0;
            int rightSum = 0;
            bool sumEquals = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int left = 0; left < i; left++)
                {
                    leftSum += numbers[left];
                }
                for (int right =i+1; right < numbers.Length;right++)
                {
                    rightSum += numbers[right];
                }
                if (leftSum==rightSum  )
                {
                    Console.WriteLine(i);
                    sumEquals = true;
                    break;
                }
                leftSum = 0;
                rightSum = 0;
            }
            if (!sumEquals)
            {
                Console.WriteLine("no");

            }

        }
    }
}
