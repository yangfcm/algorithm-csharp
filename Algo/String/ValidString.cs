using System;
using System.Collections.Generic;
using System.Linq;

namespace Algo.String
{
    /// <summary>
    /// A string is considered to be valid if all characters of the string appear the same number of times.
    /// It is also valid if you can remove just 1 character at one index in the string and the remaining characters will occur the same number of times.
    /// Given a string s, determine if it is valid as per the above rule.
    /// </summary>
    /// <example>
    /// 1. s = abc -> valid. characters all appear once.
    /// 2. s = abcc -> valid. Just remove 'c' and the remaining characters all appear once.
    /// 3. s = abccc -> invalid.
    /// </example>
    /// <source>
    /// https://www.hackerrank.com/challenges/sherlock-and-valid-string
    /// </source>
    public class ValidString
    {
        /// <summary>
        /// Iterate through the string and count each character. Use an object to store the counts for each character in the string.
        /// Sort the count as an array and if the string is valid, the array should have one of characteristics below:
        /// 1. All numbers are the same i.e. the last number equals to the first number.
        /// 2. Only the first number is 1 and the rest numbers are the same.
        /// 3. The first number is more than 1 and the last number is just bigger than the second last number by 1, and the second last number equals to the first number.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>True if s is a valid string, false otherwise.</returns>
        public static bool Solution(string s) {
            var charMap = new Dictionary<char, int>();
            foreach(char ch in s) {
                if(charMap.ContainsKey(ch) == true) {
                    charMap[ch]++;
                } else {
                    charMap.Add(ch, 1);
                }
            }
            var countValues = charMap.Values.ToArray();
            Array.Sort(countValues);
            if(countValues.Length == 1) return true;
            int first = countValues[0];
            int second = countValues[1];
            int last = countValues[^1];
            int secondLast = countValues[^2];
            if (
                first == last || 
                first == 1 && second == last ||
                first != 1 && last - secondLast == 1 && secondLast == first
            ) return true;
            return false;
        }
    }
}