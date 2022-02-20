using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Searching
{
    internal class BinarySearch : ISearch
    {
        /*
         * Time Complexity = O(logn)
         * Used when array is in sorted order
         * commonly asked in many interview questions.
         */
        public int search(int[] arr, int a)
        {
            int index = -1;
            if(arr.Length == 0)
                return -1;

            int start = 0;
            int end = arr.Length - 1;
            
            while(start < end)
            {
                int mid = start + (end - start) / 2;

                if (arr[mid] == a)
                    return mid;
                else if (arr[mid] > a)
                    end = mid - 1;
                else
                    start = mid + 1;

            }

            return index;
        }
    }
}
