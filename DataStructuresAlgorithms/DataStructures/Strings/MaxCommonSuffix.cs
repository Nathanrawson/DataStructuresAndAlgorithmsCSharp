namespace DataStructuresAlgorithms.DataStructures.Strings
{
    public static class MaxCommonSuffix
    {
        //This is a simple backward traversal solution
        public static string Get(string s1, string s2)
        {
            int point1 = s1.Length;
            int point2 = s2.Length;
            while ((point1 > 0 && point2 > 0) && s1[point1 -1] == s2[point2 -1])
            {
                point1--;
                point2--;
            }

            return s1.Substring(point1);
        }
    }
}
