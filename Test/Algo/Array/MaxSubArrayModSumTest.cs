using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Algo.Arr;

namespace Test.Algo.Arr
{
    [TestClass]
    public class MaxSubArrayModSumTest
    {
        public static IEnumerable<object[]> DataSource
        {
            get
            {
                return new[]
                { 
                    new object[] { new long[]{3, 3, 9, 9, 5}, 7, 6 },
                    new object[] { new long[]{
                      846930887,  1681692778, 1714636916, 1957747794, 424238336,  719885387,
                      1649760493, 596516650,  1189641422, 1025202363, 1350490028, 783368691,
                      1102520060, 2044897764, 1967513927, 1365180541, 1540383427, 304089173,
                      1303455737, 35005212,   521595369,  294702568,  1726956430, 336465783, 861021531,
                      278722863,  233665124,  2145174068, 468703136,  1101513930, 1801979803,
                      1315634023, 635723059,  1369133070, 1125898168, 1059961394, 2089018457,
                      628175012,  1656478043, 1131176230, 1653377374, 859484422,  1914544920,
                      608413785,  756898538,  1734575199, 1973594325, 149798316,  2038664371,
                      1129566414
                    }, 1804289384, 1802192837},
                    new object[] { new long[] {
                      412776092, 1424268981, 1911759957, 749241874, 137806863, 42999171, 982906997,
                      135497282, 511702306, 2084420926, 1937477085, 1827336328, 572660337,
                      1159126506, 805750847, 1632621730, 1100661314, 1433925858, 1141616125,
                      84353896, 939819583, 2001100546, 1998898815, 1548233368, 610515435,
                      1585990365, 1374344044, 760313751, 1477171088, 356426809, 945117277,
                      1889947179, 1780695789, 709393585, 491705404, 1918502652, 752392755,
                      1474612400, 2053999933, 1264095061, 1411549677, 1843993369, 943947740,
                      1984210013, 855636227, 1749698587, 1469348095, 1956297540, 1036140796,
                      463480571
                    }, 184803527, 184770427}
                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(DataSource))]
        public void TestSolution(long[] arr, long m, long expected)
        {
            Assert.AreEqual(expected, MaxSubArrayModSum.Solution1(arr, m));
            Assert.AreEqual(expected, MaxSubArrayModSum.Solution2(arr, m));
        }
    }
}
