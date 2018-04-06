using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeFun;

namespace LeetCodeFunTests
{
    [TestClass]
    public class PlayAroundTests
    {
        [TestMethod]
        public void L003_LengthOfLongestSubstring_Positive()
        {
            var fun = new PlayAround();
            var s1 = "abcabcbb";
            var s2 = "bbbbb";
            var s3 = "pwwkew";
            var s4 = "dvdf";
            Assert.AreEqual("abc".Length, fun.LengthOfLongestSubstring(s1));
            Assert.AreEqual("b".Length, fun.LengthOfLongestSubstring(s2));
            Assert.AreEqual("wke".Length, fun.LengthOfLongestSubstring(s3));
            Assert.AreEqual(3, fun.LengthOfLongestSubstring(s4));
        }
    }
}
