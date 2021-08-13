using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
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

            int[] sortedArray = selectionSort(arr);
            Console.WriteLine("Sorted Array: ");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }

            Console.ReadLine();
        }

        public static int[] selectionSort(int[] arr)
        {
            for (int i = 0; i < (arr.Length-1); i++)
            {
                int min = i;
                for (int j = (i+1); j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                    if (min != i)
                    {
                        int temp = arr[i];
                        arr[i] = arr[min];
                        arr[min] = temp;
                    }
                }
            }

            return arr;
        }
    }
}
