using System;
using System.Linq;

namespace _2._Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int tamesrotatate = int.Parse(Console.ReadLine());
            int[] rotatedarr = new int[arr.Length];
            int[] sumarr = new int[arr.Length];
            for (int i = 0; i < tamesrotatate; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    rotatedarr[j] = arr[j - 1];
                }
                rotatedarr[0] = arr[arr.Length - 1];

                for (int k = 0; k < arr.Length; k++)
                {
                    sumarr[k] += rotatedarr[k];

                }
                rotatedarr.CopyTo(arr, 0);
            }
            Console.WriteLine(string.Join(" ",sumarr));
        }
    }
}
