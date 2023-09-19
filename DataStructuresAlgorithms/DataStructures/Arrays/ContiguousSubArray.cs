namespace DataStructuresAlgorithms.DataStructures.Arrays
{
    //We need to find the shortest contigious subarray that sums up to or is more than K 
    public static class ContiguousSubArray
    {
        // First attempt
        //Issues
        //Returns first catch of a match 
        // Should count for anything greater than 
        public static int SlidingWindow(int[] arr, int k)
        {
            var right = 1;
            int subArrCount = 0;
            int currSum = arr[0]; 
            while (right < arr.Length)
            {
                int sum = currSum + arr[right];
                if (sum == k && subArrCount > 0)
                {
                    subArrCount++;
                    return subArrCount;
                }
                if (sum > k)
                {
                    currSum = 0;
                    subArrCount = 0;
                }
                else
                {
                    currSum = sum;
                    subArrCount++;
                }
               
                right++;
            }

            return 0;
        }

        //This is a correct solution, better using the using of the sliding window with left incrementing from left to right
        public static int SlidingWindowGPT(int[] arr, int k)
        {
            int left = 0;
            int right = 0;
            int currSum = 0;
            int minLength = int.MaxValue; // Initialized to a large value

            while (right < arr.Length)
            {
                currSum += arr[right];  // Expand the window to the right
                right++;

                //The inner loop helps us shrink the window from the left to find shortest match, while teh outer loop expand window to the right
                while (currSum >= k)
                {
                    minLength = Math.Min(minLength, right - left);
                    currSum -= arr[left];  // Shrink the window from the left
                    left++;
                }
            }

            return minLength == int.MaxValue ? 0 : minLength;
        }

    }
}
