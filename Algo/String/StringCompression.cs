namespace Algo.String
{
  /**
    * Implement a method to perform basic string compression using the counts of repeated characters.
    * Example: aabcccccaaa -> a2b1c5a3.
    * If the compressed string would not be smaller than the original string, should return original string.
    * Assume the string has only uppercase and lowercase letters a-z.
    */
  public class StringCompression
  {
    public static string Run(string str)
    {
      string compressedStr = "";
      char repeatChar = str[0];
      int repeatCharCount = 1;
      for (int i = 1; i < str.Length; i++)
      {
        char currentChar = str[i];
        if (currentChar == repeatChar)
        {
          repeatCharCount++;
        }
        else
        {
          compressedStr += repeatChar.ToString() + repeatCharCount.ToString();
          repeatChar = currentChar;
          repeatCharCount = 1;
        }
      }
      compressedStr += repeatChar.ToString() + repeatCharCount.ToString();
      return compressedStr.Length < str.Length ? compressedStr : str;
    }
  }
}