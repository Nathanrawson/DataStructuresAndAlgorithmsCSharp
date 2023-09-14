using DataStructuresAlgorithms.DataStructures.Strings;

namespace DataStructuresAlgorithms.Test.DataStructures.Strings
{
    public class MaxCommonSuffixTest
    {
        [Theory]
        [InlineData("gloom", "doom", "oom")]
        [InlineData("cat", "hat", "at")]
        [InlineData("table", "room", "")]
        [InlineData("carrot", "parrot", "arrot")]
        [InlineData("harry", "harry", "harry")]
        public void TestCommonSuffix(string s1, string s2, string answer)
        {
            var commonSuffix = MaxCommonSuffix.Get(s1, s2);
            Assert.True(commonSuffix == answer);
        }
    }
}