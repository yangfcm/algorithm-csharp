using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo;
using System;
using System.IO;

namespace Test
{
	[TestClass]
	public class StepsTest
	{
		private StringWriter sw;
		private const string ExpectedOutputWith2 = "# \r\n##\r\n";
		private const string ExpectedOutputWith3 = "#  \r\n## \r\n###\r\n";
		private const string ExpectedOutputWith4 = "#   \r\n##  \r\n### \r\n####\r\n";

		[TestInitialize]
		public void Setup()
		{
			this.sw = new StringWriter();
			Console.SetOut(this.sw);
		}

		[TestMethod]
		[DataRow(2, ExpectedOutputWith2)]
		[DataRow(3, ExpectedOutputWith3)]
		[DataRow(4, ExpectedOutputWith4)]
		public void Test(int n, string expectedOutput)
		{
			Steps.Run(n);
			var result = this.sw.ToString();
			Assert.AreEqual(result, expectedOutput);
		}
	}
}