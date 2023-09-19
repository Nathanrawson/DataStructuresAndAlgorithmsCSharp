namespace DataStructuresAlgorithms.Test.DataStructures.Arrays
{
    using DataStructuresAlgorithms.DataStructures.Arrays;
    public class SumZeroTests
    {
        [Theory]
        [InlineData(new int[] { -4, -3, -2, 1, 2, 5 }, new int[] { -2, 2 })]
        [InlineData(new int[] { -4, -3, 0, 1, 2, 5 }, new int[0])]
        [InlineData(new int[] { -7, -5, -3, 3, 4, 5 }, new int[] { -5, 5 })]
        public void TestSumZeroBruteForce(int[] arr, int[] answer)
        {
            var sumZeroArray = SumZero.BruteForce(arr);
            Assert.True(Enumerable.SequenceEqual(sumZeroArray, answer));
        }

        [Theory]
        [InlineData(new int[] { -4, -3, -2, 1, 2, 5 }, new int[] { -2, 2 })]
        [InlineData(new int[] { -4, -3, 0, 1, 2, 5 }, new int[0])]
        [InlineData(new int[] { -7, -5, -3, 3, 4, 5 }, new int[] { -5, 5 })]
        public void TestSumZeroTwoPointer(int[] arr, int[] answer)
        {
            var sumZeroArray = SumZero.TwoPointer(arr);
            Assert.True(Enumerable.SequenceEqual(sumZeroArray, answer));
        }

        [Theory]
        [InlineData(new int[] { -4, -3, -2, 1, 2, 5 }, new int[] { -2, 2 })]
        [InlineData(new int[] { -4, -3, 0, 1, 2, 5 }, new int[0])]
        [InlineData(new int[] { -7, -5, -3, 3, 4, 5 }, new int[] { -5, 5 })]
        public void TestSumZeroTwoPointerRecall(int[] arr, int[] answer)
        {
            var sumZeroArray = SumZeroRecall.TwoPointer(arr);
            Assert.True(Enumerable.SequenceEqual(sumZeroArray, answer));
        }
    }
}
