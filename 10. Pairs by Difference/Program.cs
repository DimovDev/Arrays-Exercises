using System;
using System.Linq;

namespace _10._Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers =Console.ReadLine().Split(' ').Select(int.Parse). ToArray();
            //int[] numbers = new int [] { 1 ,5, 3, 4, 2 };
            int defference = int.Parse(Console.ReadLine());
           
            int countdiff = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {


                    if (Math.Abs(numbers[i] - numbers[j + 1]) == defference)
                    {
                        countdiff++;

                    }
                }
                
            }
            Console.WriteLine(countdiff);
        }
    }
}
