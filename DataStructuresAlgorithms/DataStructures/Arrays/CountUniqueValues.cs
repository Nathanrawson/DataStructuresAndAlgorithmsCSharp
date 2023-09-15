namespace DataStructuresAlgorithms.DataStructures.Arrays
{
    //For Sorted arrays
    public static class CountUniqueValues
    {
        //My Brute force may be a slightly better solution than the sliding window solution learned from a tutorial below
        //Improvement notes: 
        //We could remove prevNum, set unique count to 1 instead, set loop to arr.lentght -1 and then just compare to future like arr[i] == arr[i+1]
        public static int BruteForce(int[] arr)
        {
            int uniqueNum = 0;
            int? prevNum = null;
            for(var i = 0; i < arr.Length; i++)
            {
                if(prevNum != arr[i])
                {
                    uniqueNum++;
                }
                prevNum = arr[i];
            }
            return uniqueNum;
        }

        //So here we are saying left and rigth start on index 0 and 1 respectiveley, we keep moving the right pointer right until a value doesent match then we pull the left pointer to that index and update the unique nums
        public static int SlidingWindow(int[] arr)
        {
            if (arr.Length == 0) return 0;

            int uniqueCount = 1;  // Since the array is sorted, the first element is always unique
            int left = 0, right = 1;

            while (right < arr.Length)
            {
                if (arr[left] != arr[right])
                {
                    uniqueCount++;
                    left = right;
                }
                right++;
            }
            return uniqueCount;
        }
    }
}
