using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresAlgorithms.DataStructures.Arrays;

namespace DataStructuresAlgorithms.Test.DataStructures.Arrays
{
    public static class ContiguousSubArrayTests
    {
        [Theory]
        [InlineData(new int[]{-1, 3, 2, 8, 1, 1, 6}, 2, 2)]
        public static void SlidingWindowTest(int[] arr, int k, int expected)
        {
            int result = ContiguousSubArray.SlidingWindow(arr, k);
            Assert.True(result == expected);
        }
    }
}
