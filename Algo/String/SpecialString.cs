namespace Algo.String
{
    /// <summary>
    /// A string is considered to be special if either of two conditions is met:
    /// 1. All the characters are the same, e.g. aaa.
    /// 2. All the characters except the middle one are the same, e.g. aadaa.
    /// Given a string s, determine how many special substrings can be formed from it.
    /// </summary>
    /// <example>
    /// s = mnonopoo -> It has 12 special substrings, they are: 'm', 'n', 'o', 'n', 'o', 'p', 'o', 'o', 'non', 'ono', 'opo', 'oo'
    /// </example>
    /// <source>
    /// https://www.hackerrank.com/challenges/special-palindrome-again
    /// </source>
    public class SpecialString
    {
        /// <summary>
        /// Consider three different scenarioes:
        /// 1. Each character is a special substring, so count them first. It's just the length of the string.
        /// 2. Count all substrings that have exact same characters.
        /// 3. Count all substrings that have one different letter in the middle and same rest letters on its both sides.
        /// </summary>
        /// <param name="s"></param>
        /// <returns>The number of special strings</returns>
        public static int Solution(string s) {
            int count = s.Length;   // 1. Each single character is a special substring, so our count starts from here.

            for (int i = 0; i < s.Length; i++) {
                // 2. Count all substrings that have exact same characters.
                for (int j = i + 1; j < s.Length; j++) {
                    if(s[j] == s[i]) count++;
                    else break;
                }
            }

            for (int i = 1; i < s.Length - 1; i++) {
                // 3. Count substrings that have one different letter in the middle and same rest letters on its both sides
                // The algorithm is for each character, except the first and last one, it should have the same letters on its left side and right side.
                char ch = s[i];
                int offset = 1;
                char next = s[i + offset];

                while(i - offset >= 0 && i + offset < s.Length) {
                    if(s[i-offset] == s[i+offset] && next == s[i+offset] && next != ch) {
                        count++;
                    } else {
                        break;
                    }
                    offset++;
                }
            }
            
            return count;
        }
    }
}