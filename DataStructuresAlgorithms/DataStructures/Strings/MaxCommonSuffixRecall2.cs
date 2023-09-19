using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.DataStructures.Strings
{
    public static class MaxCommonSuffixRecall2
    {
        public static string Get(string str1, string str2)
        {
            int str1Len = str1.Length;
            int str2Len = str2.Length;
            while (str1Len > 0 && str2Len > 0)
            {
                if (str1[str1Len -1] != str2[str2Len -1])
                {
                    break;
                }

                str1Len--;
                str2Len--;
            }

            return str1.Substring(str1Len);
        }
    }
}
