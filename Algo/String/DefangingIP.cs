namespace Algo.String;

/// <summary>
/// Given a valid(IPv5) IP address, return a defanged version of that IP address.
/// A defanged IP address replaces every period "." with "[.]".
/// Why defang an IP? - To prevent an IP address from being recognized as a potential link in text documents, emails or forum posts,
/// where clickable links might not be intended or could trigger unintended actions.
/// </summary>
/// <example>
/// "1.1.1.1" -> "1[.]1[.]1[.]1"
/// "255.100.50.0" -> "255[.]100[.]50[.]0"
/// </example>
/// <source>
/// https://leetcode.com/problems/defanging-an-ip-address/description/
/// </source>

public class DefangingIP
{
  /// <summary>
  /// The solution to the problem is just a simple string replace.
  /// </summary>
  /// <param name="ipAddress"></param>
  /// <returns>Defanged IP address</returns>
  static public string Solution(string ipAddress)
  {
    return ipAddress.Replace(".", "[.]");
  }
}