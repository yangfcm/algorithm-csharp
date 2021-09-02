using System;
using System.Collections.Generic;
using System.Linq;
using Algo.Dynamic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Algo.Dynamic
{
    [TestClass]
    public class AllConstructTest
    {
        private readonly string[] strs1 = new string[] { "purp", "p", "ur", "le", "purpl" };
        private readonly string target1 = "purple";
        private readonly string[] strs2 = new string[] { "ab", "abc", "cd", "def", "abcd", "ef", "c" };
        private readonly string target2 = "abcdef";

        [TestMethod]
        public void TestSolution1()
        {
            var expected1 = Create2DListFromArrays(
                new string[]{ "purp", "le" }, 
                new string[]{ "p", "ur", "p", "le" }
            );
            var actual1 = AllConstruct.Solution1(target1, strs1);
            Assert.IsTrue(Assert2DListsEqual(expected1, actual1));

            var expected2 = Create2DListFromArrays(
                new string[] { "ab", "cd", "ef" },
                new string[] { "ab", "c", "def" },
                new string[] { "abc", "def" },
                new string[] { "abcd", "ef" }
            );
            var actual2 = AllConstruct.Solution1(target2, strs2);
            Assert.IsTrue(Assert2DListsEqual(expected2, actual2));
        }

        [TestMethod]
        public void TestSolution2()
        {
            
            var expected1 = Create2DListFromArrays(
                new string[]{ "purp", "le" },
                new string[]{ "p", "ur", "p", "le" }
            );
            var actual1 = AllConstruct.Solution2(target1, strs1); 
            Assert.IsTrue(Assert2DListsEqual(expected1, actual1));

            var expected2 = Create2DListFromArrays(
                new string[] { "ab", "cd", "ef" },
                new string[] { "ab", "c", "def" },
                new string[] { "abc", "def" },
                new string[] { "abcd", "ef" }
            );
            var actual2 = AllConstruct.Solution2(target2, strs2);
            Assert.IsTrue(Assert2DListsEqual(expected2, actual2));
        }

        [TestMethod]
        public void TestSolution3() 
        {
            var expected1 = Create2DListFromArrays(
                new string[]{ "purp", "le" },
                new string[]{ "p", "ur", "p", "le" }
            );
            var actual1 = AllConstruct.Solution3(target1, strs1); 

            var expected2 = Create2DListFromArrays(
                new string[] { "abc", "def" },
                new string[] { "ab", "c", "def" },
                new string[] { "abcd", "ef" },
                new string[] { "ab", "cd", "ef" }
            );
            var actual2 = AllConstruct.Solution3(target2, strs2);
            
            // Console.WriteLine("+++++++Debug+++++++");
            // actual2[2].ForEach(Console.WriteLine);
            // Console.WriteLine("+++++++Debug+++++++");
            // actual2[3].ForEach(Console.WriteLine);
            Assert.IsTrue(Assert2DListsEqual(expected1, actual1));

            Assert.IsTrue(Assert2DListsEqual(expected2, actual2));
        }

        [TestMethod]
        public void TestDebug() // Test case for debugging.
        {
            string[] strs = new string[] { "ab", "a", "b", "c" };
            string target = "abc";
            var expected = Create2DListFromArrays(
                new string[] {"ab", "c"}, 
                new string[] { "a", "b", "c"}
            );
            var actual = AllConstruct.Solution2(target, strs);
            // Console.WriteLine("+++++++Debug+++++++");
            // actual[0].ForEach(Console.WriteLine);
            // Console.WriteLine("+++++++Debug+++++++");
            // actual[1].ForEach(Console.WriteLine);
            Assert.IsTrue(Assert2DListsEqual(expected, actual));
        }

        private static List<List<T>> Create2DListFromArrays<T>(params T[][] strs)
        {
            var list = new List<List<T>>();
            foreach(T[] str in strs) 
            {
                var listStr = new List<T>(str);
                list.Add(listStr);
            }
            return list;
        }

        private static bool Assert2DListsEqual<T>(List<List<T>> list1, List<List<T>> list2)
        {
            if(list1.Count != list2.Count) return false;
            for (int i = 0; i < list1.Count; i++) {
                if(!list1[i].SequenceEqual(list2[i])) return false;
            }
            return true;
        }
    }
}