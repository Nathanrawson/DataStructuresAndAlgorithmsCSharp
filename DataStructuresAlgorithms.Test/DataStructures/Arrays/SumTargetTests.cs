using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresAlgorithms.DataStructures.Arrays;

namespace DataStructuresAlgorithms.Test.DataStructures.Arrays
{
    public class SumTargetTest
    {
        [Theory]
        [InlineData(new int[] { -4, -3, -2, 1, 2, 5 }, -1, true)]
        [InlineData(new int[] { -4, -3, 0, 1, 2, 5 }, 3, true)]
        [InlineData(new int[] { -7, -5, -3, 3, 4, 5 }, 2, true)]
        public void TestSumTargetTwoPointer(int[] arr, int target, bool answer)
        {
            var foundTarget = SumTarget.TwoPointer(arr, target);
            Assert.True(foundTarget == answer);
        }
    }
}
