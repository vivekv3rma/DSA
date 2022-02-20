using System;
using DSA.Sorting;

namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 2, 4, 1, 11, 24, 12 };
            int[] arr1 = { 1, 2, 3, 4, 5, 6 };

            
            //Console.WriteLine("Testing bubble sort");
            //BubbleSort bubbleSort = new();
            //testSorting(bubbleSort, arr);
            //testSorting(bubbleSort, arr1);

            Console.WriteLine("Testing insertion sort");
            InsertionSort insertionSort = new();
            testSorting(insertionSort, arr);
            testSorting(insertionSort, arr1);

        }

        static void testSorting(ISort sortObj, int[] arr)
        {
            Utility.printArray(arr);
            sortObj.sort(arr);
            Utility.printArray(arr);
        }
    }
}
