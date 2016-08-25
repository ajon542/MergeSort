using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Sorting;


namespace MergeSortTest
{
    [TestClass]
    public class QuickSortTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> input = new List<int> { 1 };
            List<int> expected = new List<int> { 1 };

            input = QuickSort.Sort(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void TestMethod2()
        {
            List<int> input = new List<int> { 2, 1 };
            List<int> expected = new List<int> { 1, 2 };

            input = QuickSort.Sort(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void TestMethod3()
        {
            List<int> input = new List<int> { 3, 2, 1 };
            List<int> expected = new List<int> { 1, 2, 3 };

            input = QuickSort.Sort(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void TestMethod4()
        {
            List<int> input = new List<int> { 4, 3, 2, 1 };
            List<int> expected = new List<int> { 1, 2, 3, 4 };

            input = QuickSort.Sort(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void TestMethod5()
        {
            List<int> input = new List<int> { 1, 2, 3, 4 };
            List<int> expected = new List<int> { 1, 2, 3, 4 };

            input = QuickSort.Sort(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void TestMethod6()
        {
            const int ItemCount = 1000;

            Random rnd = new Random();

            List<int> input = new List<int>();

            for (int i = 0; i < ItemCount; ++i)
            {
                int random = rnd.Next(ItemCount);
                input.Add(random);
            }

            input = QuickSort.Sort(input);

            for (int i = 0; i < ItemCount - 1; ++i)
            {
                if (input[i] > input[i + 1])
                {
                    Assert.Fail("input element input[{0}]={1} is greater than input[{2}]={3}", i, input[i], i + 1, input[i + 1]);
                }
            }
        }

        [TestMethod]
        public void TestMethod7()
        {
            const int ItemCount = 1001;

            Random rnd = new Random();

            List<int> input = new List<int>();

            for (int i = 0; i < ItemCount; ++i)
            {
                int random = rnd.Next(ItemCount);
                input.Add(random);
            }

            input = QuickSort.Sort(input);

            for (int i = 0; i < ItemCount - 1; ++i)
            {
                if (input[i] > input[i + 1])
                {
                    Assert.Fail("input element input[{0}]={1} is greater than input[{2}]={3}", i, input[i], i + 1, input[i + 1]);
                }
            }
        }
    }
}
