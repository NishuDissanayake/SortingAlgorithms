using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your array length? ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];
            for (int i=0; i<length; i++)
            {
                Console.Write("Enter value for array index " + i + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] sortedArray = bucketSort(arr);
            Console.WriteLine("Sorted Array: ");
            for (int i = 0; i < sortedArray.Length; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }

            Console.ReadLine();
        }

        public static int[] bucketSort(int[] arr)
        {
            int max = 0;
            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            int[] newArr = new int[max + 1];

            for (int i=0; i<arr.Length; i++)
            {
                int currentValue = arr[i];
                newArr[currentValue] = currentValue;
            }

            return newArr;
        }
    }
}
