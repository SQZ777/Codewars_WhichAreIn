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
         
    }

    public class Kata
    {
        public static string[] inArray(string[] array1, string[] array2)
        {
            List<string> result = new List<string>();
            foreach (var a2 in array2)
            {
                foreach (var a1 in array1)
                {
                    if (a2.Equals(a1))
                    {
                        result.Add(a2);
                    }
                }
            }
            return result.ToArray();
        }
    }
}
