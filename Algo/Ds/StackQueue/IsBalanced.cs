using System.Collections.Generic;

namespace Algo.Ds.StackQueue
{
    /// <summary>
    /// Given a string, return true or false to indicate whether the string has balanced brackets.
    /// Brackets can be '[]', '{}', or '()'
    /// </summary>
    /// <example>
    /// s = "{[()]}" -> true
    /// s = "{[(])} " -> false
    /// s = "{{[[(())]]}}" -> true
    /// s = "abcd" -> true  If there is no brackets, we should also consider it as balanced.
    /// </example>
    /// <source>
    /// https://www.hackerrank.com/challenges/balanced-brackets/problem
    /// </source>
    public class IsBalanced
    {
        static public bool Solution(string str)
        {
            Stack<char> bracketStack = new();

            foreach(char ch in str)
            {
                if(ch == '(' || ch == '{' || ch == '[')
                {
                    bracketStack.Push(ch);
                }

                if(
                    (ch==')' && bracketStack.Peek() != '(') || 
                    (ch=='}' && bracketStack.Peek() != '{') || 
                    (ch==']' && bracketStack.Peek() != '[')
                ) {
                    return false;
                }

                if(
                    (ch==')' && bracketStack.Peek() == '(') || 
                    (ch=='}' && bracketStack.Peek() == '{') || 
                    (ch==']' && bracketStack.Peek() == '[')
                ) {
                    bracketStack.Pop();
                }
            }

            return bracketStack.Count == 0;
        }
    }
}