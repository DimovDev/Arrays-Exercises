using System;
using System.Linq;

namespace _8._Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {

           int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
           //nt[] A = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int[] count = new int[A.Length];
            int countMax = 0;
            int numberMax = 0;
            for (int i = 0; i < A.Length;i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (A[i] == A[j])
                    {
                        count[i]++;
                        if (count[i] > countMax)
                        {
                            countMax = count[i];
                            numberMax = A[i];
                        }

                    }
                }


            }
            Console.WriteLine(numberMax);

        }
    }

}
