using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Sorting;

namespace MergeSortTest
{
    [TestClass]
    public class MergeSortTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            MergeSort sort = new MergeSort();

            int[] input = { 1 };
            int[] expected = { 1 };

            sort.Sort(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MergeSort sort = new MergeSort();

            int[] input = { 2, 1 };
            int[] expected = { 1, 2 };

            sort.Sort(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MergeSort sort = new MergeSort();

            int[] input = { 3, 2, 1 };
            int[] expected = { 1, 2, 3 };

            sort.Sort(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void TestMethod4()
        {
            MergeSort sort = new MergeSort();

            int[] input = { 3, 2, 1, 10 };
            int[] expected = { 1, 2, 3, 10 };

            sort.Sort(input);

            CollectionAssert.AreEqual(expected, input);
        }
    }
}
