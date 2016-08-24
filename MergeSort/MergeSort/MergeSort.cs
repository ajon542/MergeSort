using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    /// <summary>
    /// Implementation of the Merge Sort algorithm.
    /// </summary>
    public class MergeSort
    {
        public static void MergeSort_Recursive(int[] arr)
        {
            MergeSort_Recursive(arr, 0, arr.Length, new int[arr.Length]);
        }

        private static void MergeSort_Recursive(int[] arr, int start, int end, int[] work)
        {
            // If the run size is 1, consider it sorted.
            if (end - start < 2)
            {
                return;
            }

            int middle = (end + start) / 2;

            MergeSort_Recursive(arr, start, middle, work);
            MergeSort_Recursive(arr, middle, end, work);
            Merge(arr, start, middle, end, work);

            for (int k = start; k < end; ++k)
            {
                arr[k] = work[k];
            }
        }

        private static void Merge(int[] arr, int start, int middle, int end, int[] work)
        {
            int i = start;
            int j = middle;

            for (int k = start; k < end; ++k)
            {
                if (i < middle && (j >= end || arr[i] <= arr[j]))
                {
                    work[k] = arr[i++];
                }
                else
                {
                    work[k] = arr[j++];
                }
            }
        }
    }
}
