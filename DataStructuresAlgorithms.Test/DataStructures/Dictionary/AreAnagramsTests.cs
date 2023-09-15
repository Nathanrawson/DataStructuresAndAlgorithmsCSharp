using DataStructuresAlgorithms.DataStructures.Dictionarys;

namespace DataStructuresAlgorithms.Test.DataStructures.Dictionary
{
    public class AreAnagramsTests
    {
        [Theory]
        [InlineData("mood", "doom", true)]
        [InlineData("cat", "hat", false)]
        [InlineData("table", "ablet", true)]
        [InlineData("carrot", "parrot", false)]
        [InlineData("harry", "harryss", false)]
        public void TestAreanagrams(string s1, string s2, bool answer)
        {
            var anagrams = AreAnagrams.FrequenceyCounter(s1, s2);
            Assert.True(anagrams == answer);
        }
    }
}
