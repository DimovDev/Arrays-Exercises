using System;
using System.Linq;

namespace _5._Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] array2 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            int max = Math.Max(array1.Length, array2.Length);
            if (array1.Length > array2.Length)
            {
                Console.WriteLine(string.Join("", array2));
               
                Console.Write(string.Join("", array1));
                Console.WriteLine();
                return;

            }
            else if ((array1.Length < array2.Length))
            {
                Console.Write(string.Join("", array1));
               
                Console.Write(string.Join("", array2));
                Console.WriteLine();
                
            }
        
               
                if (array1.Length == array2.Length&& array1[0] < array2[0])
             
                    {
                        Console.WriteLine(string.Join("", array1));
                        Console.WriteLine(string.Join("", array2));
                        Console.WriteLine();


            }

            else if (array1.Length == array2.Length && array1[0] > array2[0])
            {
                        Console.WriteLine(string.Join("", array2));
                        Console.WriteLine(string.Join("", array1));
                        Console.WriteLine();

            }
        }
            }
        }
    

