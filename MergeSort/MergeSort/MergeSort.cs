
namespace Sorting
{
    /// <summary>
    /// Implementation of the Merge Sort algorithm.
    /// </summary>
    public class MergeSort
    {
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
    }
}
