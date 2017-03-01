using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            int wz;
            Random rand_num = new Random();

            for(int i = 0; i < array.Length; i++)//generating array
            {
                array[i] = rand_num.Next(1, 101);
            }

            Console.Write("Unsorted array: ");
            for (int i = 0; i < array.Length; i++)//Output starter array
                Console.Write(array[i] + " ");

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)//Cycle of Bubble sorting
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        wz = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = wz;
                    }
                }
            }

            Console.Write("Sorted array: ");
            for (int i = 0; i < array.Length; i++)//Output sorted array
                Console.Write(array[i] + " ");

            Console.ReadKey();
        }
    }
}
