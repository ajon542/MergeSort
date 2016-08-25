using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class QuickSort
    {
        public static List<int> Sort(List<int> input)
        {
            return Sort(input, 0, input.Count - 1);
        }

        private static List<int> Sort(List<int> input, int left, int right)
        {
            int index = 0;

            if (input.Count > 1)
            {
                index = Partition(input, left, right);

                if (left < index - 1)
                {
                    Sort(input, left, index - 1);
                }

                if (index < right)
                {
                    Sort(input, index, right);
                }
            }

            return input;
        }

        private static int Partition(List<int> input, int left, int right)
        {
            int pivot = input[(left + right) >> 1];
            int i = left;
            int j = right;

            while (i <= j)
            {
                while (input[i] < pivot)
                {
                    i++;
                }

                while (input[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    Swap(input, i, j);

                    i++;
                    j--;
                }
            }

            return i;
        }

        private static void Swap(List<int> input, int a, int b)
        {
            int tmp = input[a];
            input[a] = input[b];
            input[b] = tmp;
        }
    }
}
