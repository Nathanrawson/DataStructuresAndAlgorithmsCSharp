namespace DataStructuresAlgorithms.DataStructures.Dictionarys
{
    public class AreAnagrams
    {
        //This solution uses the frequencey counter technique, so we tally up the frequencey of chars for each string and then compare the frequencies match to determine if they are anagrams
        public static bool FrequenceyCounter(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            Dictionary<char, int> frequencyCounter = new Dictionary<char, int>();

            for (int i = 0; i < str1.Length; i++)
            {
                char charFromStr1 = str1[i];
                char charFromStr2 = str2[i];

                // Increase count for charFromStr1
                if (frequencyCounter.ContainsKey(charFromStr1))
                {
                    frequencyCounter[charFromStr1]++;
                }
                else
                {
                    frequencyCounter[charFromStr1] = 1;
                }

                // Decrease count for charFromStr2
                if (frequencyCounter.ContainsKey(charFromStr2))
                {
                    frequencyCounter[charFromStr2]--;
                }
                else
                {
                    frequencyCounter[charFromStr2] = -1;
                }
            }

            // If every value in the dictionary is 0, then they are anagrams
            foreach (int val in frequencyCounter.Values)
            {
                if (val != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
