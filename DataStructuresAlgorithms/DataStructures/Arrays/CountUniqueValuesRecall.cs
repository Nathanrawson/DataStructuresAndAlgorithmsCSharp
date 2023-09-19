using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.DataStructures.Arrays
{
    public static class CountUniqueValuesRecall
    {
        public static int Slidingwindow(int[] arr)
        {
            var left = 0;
            var right = 1;
            int uniqueCount = 1;
            while (right < arr.Length)
            {
                if (arr[left] != arr[right])
                {
                    left = right;
                    uniqueCount++;
                }

                right++;
            }

            return uniqueCount;
        }
    }
}
