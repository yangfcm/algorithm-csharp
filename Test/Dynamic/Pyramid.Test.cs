using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo;
using System;
using System.IO;

namespace Test
{
	[TestClass]
	public class PyramidTest
	{
		private StringWriter sw;
		private const string ExpectedOutputWith2 = " # \r\n###\r\n";
		private const string ExpectedOutputWith3 = "  #  \r\n ### \r\n#####\r\n";
		private const string ExpectedOutputWith4 = "   #   \r\n  ###  \r\n ##### \r\n#######\r\n";

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
		public void TestPyramid(int n, string expectedOutput)
		{
			Pyramid.Run(n);
			var result = this.sw.ToString();
			Assert.AreEqual(result, expectedOutput);
		}

	}
}