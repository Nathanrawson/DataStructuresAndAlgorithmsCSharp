namespace DataStructuresAlgorithms.DataStructures.Strings
{
    public class MaxCommonSuffixRecall
    {
        public static string Get(string s1, string s2)
        {
            int s1Length = s1.Length;
            int s2Length = s2.Length;
            while (s1Length > 0 && s2Length > 0)
            {
                if (s1[s1Length -1] != s2[s2Length -1])
                {
                    break;
                }

                s1Length--;
                s2Length--;
            }

            return s1.Substring(s1Length);
        }
    }
}
