using System;
using System.Collections.Generic;

namespace task1
{
    class Program
    {
        public static List<int> Sort(params int[] x)
        {
            List<int> sortedArray = new List<int>();

            int numOfBuckets = 10;            
            List<int>[] buckets = new List<int>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<int>();
            }

            for (int i = 0; i < x.Length; i++)
            {
                int bucket = (x[i] / numOfBuckets);
                buckets[bucket].Add(x[i]);
            }

            for (int i = 0; i < numOfBuckets; i++)
            {
                List<int> temp = InsertionSort(buckets[i]);
                sortedArray.AddRange(temp);
            }
            return sortedArray;
        }        
        public static List<int> InsertionSort(List<int> input)
        {
            for (int i = 1; i < input.Count; i++)
            {
                int currentValue = input[i];
                int pointer = i - 1;

                while (pointer >= 0)
                {
                    if (currentValue < input[pointer])
                    {
                        input[pointer + 1] = input[pointer];
                        input[pointer] = currentValue;
                    }
                    else break;
                }
            }

            return input;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 15, 1727, 22, 66, 11, 6, 363, 23, 83, 21, 47, 511 };

            Console.WriteLine("Bucket Sort");

            PrintArray(array);

            List<int> sorted = Sort(array);

            PrintArray(sorted);
            Console.ReadLine();
        }

        static void PrintArray(List<int> arr)
        {
            for(int i = 0; i < arr.Count; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
        }
    }
}
