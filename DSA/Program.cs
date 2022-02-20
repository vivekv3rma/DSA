using System;
using DSA.Sorting;

namespace DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            testBubbleSort();
        }

        static void testBubbleSort()
        {
            BubbleSort sort = new();
            int[] arr = { 10, 2, 4, 1, 11, 24, 12 };
            Utility.printArray(arr);
            sort.sort(arr);
            Utility.printArray(arr);

        }
    }
}
