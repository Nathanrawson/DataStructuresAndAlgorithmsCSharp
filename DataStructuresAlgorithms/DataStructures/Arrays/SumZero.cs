namespace DataStructuresAlgorithms.DataStructures.Arrays
{
    public static class SumZero
    {
        //This is my original slower brute force approach in O(n2)
        public static int[] BruteForce(int[] sortedArray)
        {
            for (int i = 0; i < sortedArray.Length; i++)
            {
                for (int k = i + 1; k < sortedArray.Length; k++)
                {
                    if (sortedArray[i] + sortedArray[k] == 0)
                    {
                        return new int[] { sortedArray[i], sortedArray[k] };
                    }
                }
            }
            return new int[0]; 
        }

        // This approach is in O(n), much faster two pointer technique solution 
        public static int[] TwoPointer(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                int sum = arr[left] + arr[right];

                if (sum == 0)
                {
                    return new int[] { arr[left], arr[right] };
                }

                if (sum > 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return new int[0];
        }
    }
}
