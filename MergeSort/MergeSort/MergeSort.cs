using System.Collections.Generic;
using System.Linq;

namespace Sorting
{
    /// <summary>
    /// Implementation of the Merge Sort algorithm.
    /// </summary>
    public class MergeSort
    {
        #region Array Implementation

        public static void MergeSort_Recursive(int[] input)
        {
            MergeSort_Recursive(input, 0, input.Length, new int[input.Length]);
        }

        private static void MergeSort_Recursive(int[] input, int left, int right, int[] tmp)
        {
            // If the run size is 1, consider it sorted.
            if (right - left < 2)
            {
                return;
            }

            int middle = (right + left) / 2;

            MergeSort_Recursive(input, left, middle, tmp);
            MergeSort_Recursive(input, middle, right, tmp);
            Merge(input, left, middle, right, tmp);

            for (int k = left; k < right; ++k)
            {
                input[k] = tmp[k];
            }
        }

        private static void Merge(int[] input, int left, int middle, int right, int[] tmp)
        {
            int i = left;
            int j = middle;

            for (int k = left; k < right; ++k)
            {
                if (i < middle && (j >= right || input[i] <= input[j]))
                {
                    tmp[k] = input[i++];
                }
                else
                {
                    tmp[k] = input[j++];
                }
            }
        }

        #endregion

        #region List Implementation

        public static List<int> MergeSort_Recursive(List<int> input)
        {
            if (input.Count <= 1)
            {
                return input;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();
            for(int i = 0; i < input.Count; ++i)
            {
                if (i % 2 == 0)
                {
                    right.Add(input[i]);
                }
                else
                {
                    left.Add(input[i]);
                }
            }

            left = MergeSort_Recursive(left);
            right = MergeSort_Recursive(right);

            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            int l = 0;
            int r = 0;
            while (l < left.Count && r < right.Count)
            {
                if (left[l] <= right[r])
                {
                    result.Add(left[l++]);
                }
                else
                {
                    result.Add(right[r++]);
                }
            }

            while (l < left.Count)
            {
                result.Add(left[l++]);
            }
            while (r < right.Count)
            {
                result.Add(right[r++]);
            }
            return result;
        }

        #endregion
    }
}
