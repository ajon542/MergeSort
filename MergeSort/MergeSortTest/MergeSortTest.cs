using System;
using System.Collections.Generic;
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
            int[] input = { 1 };
            int[] expected = { 1 };

            MergeSort.MergeSort_Recursive(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] input = { 2, 1 };
            int[] expected = { 1, 2 };

            MergeSort.MergeSort_Recursive(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] input = { 3, 2, 1 };
            int[] expected = { 1, 2, 3 };

            MergeSort.MergeSort_Recursive(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] input = { 3, 2, 1, 10 };
            int[] expected = { 1, 2, 3, 10 };

            MergeSort.MergeSort_Recursive(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void TestMethod5()
        {
            const int ItemCount = 1000;

            Random rnd = new Random();

            int[] input = new int[ItemCount];

            for (int i = 0; i < ItemCount; ++i)
            {
                int random = rnd.Next(ItemCount);
                input[i] = random;
            }

            MergeSort.MergeSort_Recursive(input);

            for (int i = 0; i < ItemCount - 1; ++i)
            {
                if (input[i] > input[i + 1])
                {
                    Assert.Fail("input element input[{0}]={1} is greater than input[{2}]={3}", i, input[i], i + 1, input[i + 1]);
                }
            }
        }

        [TestMethod]
        public void TestMethod6()
        {
            List<int> input = new List<int> { 1 };
            List<int> expected = new List<int> { 1 };

            input = MergeSort.MergeSort_Recursive(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void TestMethod7()
        {
            List<int> input = new List<int> { 2, 1 };
            List<int> expected = new List<int> { 1, 2 };

            input = MergeSort.MergeSort_Recursive(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void TestMethod8()
        {
            List<int> input = new List<int> { 3, 2, 1 };
            List<int> expected = new List<int> { 1, 2, 3 };

            input = MergeSort.MergeSort_Recursive(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void TestMethod9()
        {
            List<int> input = new List<int> { 3, 2, 1, 10 };
            List<int> expected = new List<int> { 1, 2, 3, 10 };

            input = MergeSort.MergeSort_Recursive(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod]
        public void TestMethod10()
        {
            const int ItemCount = 1000;

            Random rnd = new Random();

            List<int> input = new List<int>();

            for (int i = 0; i < ItemCount; ++i)
            {
                int random = rnd.Next(ItemCount);
                input.Add(random);
            }

            input = MergeSort.MergeSort_Recursive(input);

            for (int i = 0; i < ItemCount - 1; ++i)
            {
                if (input[i] > input[i + 1])
                {
                    Assert.Fail("input element input[{0}]={1} is greater than input[{2}]={3}", i, input[i], i + 1, input[i + 1]);
                }
            }
        }

        [TestMethod]
        public void TestMethod11()
        {
            const int ItemCount = 1001;

            Random rnd = new Random();

            List<int> input = new List<int>();

            for (int i = 0; i < ItemCount; ++i)
            {
                int random = rnd.Next(ItemCount);
                input.Add(random);
            }

            input = MergeSort.MergeSort_Recursive(input);

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
