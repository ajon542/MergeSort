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
        /// <summary>
        /// Sort the array of integers.
        /// </summary>
        /// <param name="arr">The array of integers.</param>
        public void Sort(int[] arr)
        {
            MergeSort_Recursive(arr, new int[arr.Length]);
        }

        private void MergeSort_Recursive(int[] arr, int[] work)
        {
            SplitMerge(arr, 0, arr.Length, work);
        }

        private void SplitMerge(int[] arr, int start, int end, int[] work)
        {
            // If the run size is 1, consider it sorted.
            if (end - start < 2)
            {
                return;
            }

            int middle = (end + start) / 2;

            SplitMerge(arr, start, middle, work);
            SplitMerge(arr, middle, end, work);
            Merge(arr, start, middle, end, work);

            for (int k = start; k < end; ++k)
            {
                arr[k] = work[k];
            }
        }

        private void Merge(int[] arr, int start, int middle, int end, int[] work)
        {
            int i = start;
            int j = middle;

            for(int k = start; k < end; ++k)
            {
                if(i < middle && (j >= end || arr[i] <= arr[j]))
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
