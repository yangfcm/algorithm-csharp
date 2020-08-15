namespace Algo.String
{
  /*
	Capitalize
	Given a string, capitalize the first letter of each word
	in the string then return the capitalized string.
	e.g. capitalize('it is so good!') --> It Is So Good    
	 */
  public class Capitalize
  {
    static public string Run(string str)
    {
      string capStr;
      capStr = str[0].ToString().ToUpper();
      // If the left side of the current letter is a blank, it means it is the first letter of a word,
      // Make it uppercase.
      for (int i = 1; i < str.Length; i++)
      {
        if (str[i - 1] == ' ')
        {
          capStr += str[i].ToString().ToUpper();
        }
        else
        {
          capStr += str[i];
        }
      }
      return capStr;
    }
  }
}