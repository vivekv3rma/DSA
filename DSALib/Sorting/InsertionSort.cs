using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting
{
    public class InsertionSort : ISort
    {
        /*
         * Time Complexity - O(n2)
         * Space Complexity - n
         * Stable sorting algo
         * Adaptive - steps get reduced if array is sorted
         * Number of swap reduced as compared to bubble sort.
         * Used for smaller size array
         * Works good when array is partially sorted
         * Takes part in hybrid sorting algorithms - combination of merge sort/quick sort etc with insertion sort
         */
        public void sort(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                for(int j = i+1; j > 0; j--)
                {
                    if (arr[j] < arr[j-1])
                        Utility.swapArrayElements(arr, j, j-1);
                    else
                        break;
                }
                //Utility.printArray(arr); //print array after each iteration
            }
        }
    }
}
