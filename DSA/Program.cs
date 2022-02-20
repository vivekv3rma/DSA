using System;
using DSA.Sorting;
using DSA.Searching;

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

            //Console.WriteLine("Testing insertion sort");
            //InsertionSort insertionSort = new();
            //testSorting(insertionSort, arr);
            //testSorting(insertionSort, arr1);

            Console.WriteLine("Testing binary search");
            BinarySearch binarySearch = new();
            testSearching(binarySearch, arr1, 11);
        }

        static void testSearching(ISearch searchObj, int[] arr, int a)
        {
            Utility.printArray(arr);
            Console.WriteLine("Index of " + a + " : " + searchObj.search(arr, a));
        }

        static void testSorting(ISort sortObj, int[] arr)
        {
            Utility.printArray(arr);
            sortObj.sort(arr);
            Utility.printArray(arr);
        }
    }
}
