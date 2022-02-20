using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Sorting
{
    internal class InsertionSort : ISort
    {
        public override void sort(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
            {
                int key = arr[i];

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
