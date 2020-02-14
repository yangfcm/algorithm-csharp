namespace Algo
{
	/**
	Take a string and return true or false to indicate whether its curly braces are balanced
	e.g. '}{' => false,
	'{abc}{def}' => true
	'{abc {def}}' => true
	'{abc {{def}}' => false
	*/
	public class IsBalanced
	{
		static public bool Run(string str)
		{
			int count = 0;
			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] == '{')
				{
					count++;
				}
				if (str[i] == '}')
				{
					count--;
					if (count < 0) return false;
				}
			}
			return count == 0;
		}
	}
}