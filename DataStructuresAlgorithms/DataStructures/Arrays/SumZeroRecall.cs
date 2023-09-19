namespace DataStructuresAlgorithms.DataStructures.Arrays
{
    public class SumZeroRecall
    {
        public static int[] TwoPointer(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (right > left)
            {
                var sum = arr[right] + arr[left];
           
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
            return Array.Empty<int>();
        }
    }
}
