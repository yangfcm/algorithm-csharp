/**
 * In C#, you have method Contains to check if one string is a substring of another.
 * Given two strings, check if s2 is a rotation of s1 using only one call to Contains.
 * If a string is a rotation of another, it's a rotation at a particular point.
 * e.g. a rotation of "waterbottle" at character 3 means cutting this string at character 3 and 
 * putting the right half('erbottle') before the left half('wat')
 * so the result is "erbottlewat"
 */
namespace Algo.String
{
  public class CheckStringRotation
  {
    public static bool Run(string str1, string str2)
    {
      if (str1.Length != str2.Length || str1.Length == 0 || str2.Length == 0)
      {
        // If str1 and str2 are different in length, or either of them is empty string, return false early.
        return false;
      }
      return (str1 + str1).Contains(str2);
    }
  }
}