using Algorithms;
using NUnit.Framework;

namespace AlgorithmsTest_
{
    public class Tests
    {
        [TestCase(new int[]{8, 2, 6, 10, 4}, new int[] { 2, 4, 6, 8, 10 })]
        public void BubbleSortByLoop_WhenCalled_SortedFromSmallToLarge(int[] testData, int[] expected)
        {
            //Arrange

            //Act
            BubbleSort.BubbleSortByLoop(testData);

            //Assert
            Assert.AreEqual(expected, testData);
        }

        [TestCase(new int[] { 8, 2, 6, 10, 4 }, new int[] { 2, 4, 6, 8, 10 })]
        public void BubbleSortByRecursion_WhenCalled_SortedFromSmallToLarge(int[] testData, int[] expected)
        {
            //Arrange

            //Act
            BubbleSort.BubbleSortByRecursion(testData);

            //Assert
            Assert.AreEqual(expected, testData);
        }

        [TestCase(new int[] { 8, 2, 6, 10, 4 }, new int[] { 10, 8, 6, 4, 2})]
        public void InsertionSortByLoop_WhenCalled_SortedFromLargeToSmall(int[] testData, int[] expected)
        {
            //Arrange

            //Act
            InsertionSort.InsertionSortByLoop(testData);

            //Assert
            Assert.AreEqual(expected, testData);
        }

        [TestCase(new int[] { 8, 2, 6, 10, 4 }, new int[] { 10, 8, 6, 4, 2 })]
        public void InsertionSortByRecursion_WhenCalled_SortedFromLargeToSmall(int[] testData, int[] expected)
        {
            //Arrange

            //Act
            InsertionSort.InsertionSortByRecursion(testData);

            //Assert
            Assert.AreEqual(expected, testData);
        }
    }
}