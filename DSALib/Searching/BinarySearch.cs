using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Searching
{
    public class BinarySearch : ISearch
    {
        /// <summary>
        /// Time Complexity = O(logn)
        /// Used when array is in sorted order
        /// commonly asked in many interview questions.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="a"></param>
        /// <returns>index of element in array </returns>
        public int search(int[] arr, int a)
        {
            int index = -1;
            if (arr.Length == 0)
                return -1;

            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
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

        /// <summary>
        /// Binary search in 2D-Array
        /// </summary>
        /// <param name="arr">2D Array</param>
        /// <param name="a">Element to search</param>
        /// <returns>2D array element position</returns>
        public int[] search(int[][] arr, int a)
        {
            int row = 0;
            int col = arr.Length - 1;
            int[] ans = { -1, -1 };
            
            while(row < arr.Length && col >= 0)
            {
                if (arr[row][col] == a)
                {
                    ans[0] = row;
                    ans[1] = col;
                    break;
                }
                else if (arr[row][col] > a)
                {
                    col--;
                }
                else
                    row++;
            }

            return ans;
        }
    }
}
