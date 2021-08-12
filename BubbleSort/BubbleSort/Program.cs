using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your array length? ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter value for array index " + i + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] sortedArray = bubbleSort(arr);
            Console.WriteLine("Sorted Array: ");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }

            Console.ReadLine();
        }

        public static int[] bubbleSort(int[] arr)
        {
            for (int i = 0; i < (arr.Length - 1); i++)
            {
                for (int j = 0; j < (arr.Length - i -1); j++)
                {
                   if (arr[j] > arr[j + 1])
                    {
                        int swap = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swap;
                    }
                }
            }

            return arr;
        }
    }
}
