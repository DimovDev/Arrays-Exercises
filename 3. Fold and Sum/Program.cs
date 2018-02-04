using System;
using System.Linq;

namespace _3._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputarr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] leftFold = new int[inputarr.Length / 4];
            int[] rightFold = new int[inputarr.Length / 4];
            int[] resultArray = new int[inputarr.Length / 2];
            for (int i = 0; i < (inputarr.Length/4); i++)
            {
                leftFold[i] = inputarr[(inputarr.Length / 4 )- 1 - i];
                rightFold[i] = inputarr[inputarr.Length - 1 - i];
            }
            for (int i = 0; i < inputarr.Length/4; i++)
            {
                resultArray[i] = leftFold[i] + inputarr[inputarr.Length / 4 + i];
                resultArray[inputarr.Length / 4 + i] = rightFold[i] + inputarr[inputarr.Length / 2 + i];
            }
            Console.WriteLine(string.Join(" ",resultArray));
        }
    }
}
