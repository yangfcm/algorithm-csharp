using System;
using System.Collections;
using System.Collections.Generic;

namespace Algo.Greedy
{
    /// <summary>
    ///  We define some operations on a string as follows:
    /// 1. Reverse, reverse a string e.g. Reverse 'abc' is 'cba'
    /// 2. Shuffle, shuffle the characters in a string. e.g. Shuffle 'abc' can be 'abc', 'acb', 'bac', 'bca', 'cba', 'cab'
    /// 3. Merge, intersperse two strings with maintaining the order of characters in both.
    /// e.g. Merge 'abc' and 'def' can be 'abcdef', 'adbecf', 'abdefc', 'adefbc' etc.
    /// Given a string s such that s is one of the results of the operation: merge(reverse(A), shuffle(A)) (A is another string)
    /// find out the lexicographically smallest(字典排序中最小/前的一個) A
    /// </summary>
    /// <example>
    /// Example 1: s = eggegg -> egg
    /// reverse('egg') -> 'gge', shuffle('egg') -> 'egg', 'eggegg' belongs to the merge of ('gge', 'egg')
    /// Example 2: s = abcdefgabcdefg -> agfedcb
    /// reverse('agfedcb') -> 'bcdefga', shuffle('agfedcb') -> 'abcdefg', 'bcdefgabcdefg' belongs to the merge of ('bcdefga','abcdefg')
    /// </example>
    /// <source>
    /// https://www.hackerrank.com/challenges/reverse-shuffle-merge
    /// </source>
    public class ReverseShuffleMerge
    {
        /// <summary>
        /// Reverse a string
        /// </summary>
        /// <param name="s"></param>
        /// <returns>A reversed string</returns>
        private static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            string reversedStr = "";
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                reversedStr += charArray[i];
            }
            return reversedStr;
        }

        private static string CharListToString(LinkedList<char> charList)
        {
            string str = "";
            foreach(char ch in charList)
            {
                str += ch;
            }
            return str;
        }

        /// <summary>
        /// Because s is the intersperse of two strings with exact same letters, we can easily find out the letters for string A.
        /// To do it, use an object as char-count pair. For example, s = eggegg, we can know
        /// string A has one letter 'e' and two letter 'g's, so keep the information in an object like: { e: 1, g: 2, }.
        /// Next, we need to put these letters in correct order, such that s = merge(reverse(A), shuffle(A)).
        /// Considering the characteristics of the string s, if we reverse the string, like 'ggegge', we can know that string A is contained in it with the right order.
        /// So the task is to find one 'e' and two 'g's from 'ggegge' in the order. And the lexicographically smallest one is exactly the string A we want.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>The lexicographically smallest string A from defined operations.</returns>
        public static string Solution(string s)
        {
            string reversedStr = ReverseString(s);
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            var strCharMap = new Dictionary<char, int>();
            var shuffleStrCharMap = new Dictionary<char, int>();
            for (int i = 0; i < charArray.Length; i+=2)
            {
                var ch = charArray[i];
                if(strCharMap.ContainsKey(ch))
                {
                    strCharMap[ch]++;
                    shuffleStrCharMap[ch]++;
                }
                else
                {
                    strCharMap.Add(ch, 1);
                    shuffleStrCharMap.Add(ch, 1);
                }
            }

            LinkedList<char> strArr = new ();
            for (int i = 0; i < reversedStr.Length; i++)
            {
                char ch = reversedStr[i];
                if(strCharMap[ch] > 0)
                {
                    while(
                        strArr.Count > 0 &&
                        strArr.Last.Value > ch &&
                        shuffleStrCharMap[strArr.Last.Value] > 0
                    )
                    {
                        char lastChar = strArr.Last.Value;
                        strArr.RemoveLast();
                        shuffleStrCharMap[lastChar]--;
                        strCharMap[lastChar]++;
                    }
                    strArr.AddLast(ch);
                    strCharMap[ch]--;
                }
                else
                {
                    shuffleStrCharMap[ch]--;
                }
            }
            return CharListToString(strArr);
        }
    }
}