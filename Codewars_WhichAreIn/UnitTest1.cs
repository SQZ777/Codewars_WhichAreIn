using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Codewars_WhichAreIn
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_arpAnd_aaa_Should_Be_EmptyArray()
        {
            var actual = Kata.inArray(new string[] { "arp" }, new string[] { "aaa" });
            var expected = new string[] { };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input_arpAndarp_Should_Be_arpOfArray()
        {
            var actual = Kata.inArray(new string[] { "arp" }, new string[] { "arp" });
            var expected = new string[] { "arp" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input_ss_arpAndarp_Should_Be_arpOfArray()
        {
            var actual = Kata.inArray(new string[] {"ss", "arp"}, new string[] {"arp"});
            var expected = new string[] {"arp"};
            CollectionAssert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Input_ss_arp_And_art_starpoint_Should_Be_arp()
        {
            var actual = Kata.inArray(new string[] {"ss", "arp"}, new string[] {"art", "starpoint"});
            var expected =new string[]{"arp"};
            CollectionAssert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void CodewarsExampleTest()
        {
            var actual = Kata.inArray(new string[] {"arp", "live", "strong"},
                new string[] {"lively", "alive", "harp", "sharp", "armstrong"});
            var expected = new string[] { "arp", "live", "strong" };
            CollectionAssert.AreEqual(expected,actual);
        }
    }

    public class Kata
    {
        public static string[] inArray(string[] array1, string[] array2)
        {
            List<string> result = new List<string>();
            foreach (var a1 in array1)
            {
                foreach (var a2 in array2)
                {   
                    if (a2.Contains(a1)&& !result.Contains(a1))
                    {
                        result.Add(a1);
                    }
                }
            }
            return result.ToArray();
        }
    }
}
