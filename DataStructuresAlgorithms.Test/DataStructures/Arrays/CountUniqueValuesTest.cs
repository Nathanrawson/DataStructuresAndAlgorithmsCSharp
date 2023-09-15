using DataStructuresAlgorithms.DataStructures.Arrays;

namespace DataStructuresAlgorithms.Test.DataStructures.Arrays
{
    public class CountUniqueValuesTest
    {
        [Theory]
        [InlineData(new int[] {  1, 2, 3, 4, 5, 10, 10 }, 6)]
        [InlineData(new int[] { 10, 200, 300, 400, 5000, 100000, 100000000 }, 7)]
        [InlineData(new int[] { -1, -1, -1, 4, 5, 10, 10 }, 4)]
        public void TestUniqueValuesBruteForce(int[] arr, int answer)
        {
            Assert.True(CountUniqueValues.BruteForce(arr) == answer);
        }
    }
}
