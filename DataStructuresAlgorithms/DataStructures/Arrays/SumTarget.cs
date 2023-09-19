using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.DataStructures.Arrays
{
    public static class SumTarget
    {
        public static bool TwoPointer(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length -1;
            while (right > left)
            {
                var sum = arr[left] + arr[right];
                if (sum == target)
                    return true;
                if (sum > target)
                {

                    right--;
                }
                else
                {
                    left++;
                }
            }

            return false;
        }
    }
}
