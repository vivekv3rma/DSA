using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting
{
    public class BubbleSort : ISort
    {
        /*
         * Time Complexity - O(n2)
         * Space Complexity - 
         * Stable sorting algo
         */
        public void sort(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                bool swapped = false;
                for(int j = i+1; j < arr.Length; j++)
                {
                    if(arr[j] < arr[i])
                    {
                        Utility.swapArrayElements(arr, i, j);
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }
    }
}
