using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Ds.Tree.Bst;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Test.Ds.Tree.Bst
{
    [TestClass]
    public class SwapNodesTest
    {
        public static IEnumerable<object[]> DataSource
        {
            get
            {
                return new[]
                {
                    new object[] {
                        new int[][]{    // argument 1: indexes
                            new int[]{2, 3},
                            new int[]{-1, -1},
                            new int[]{-1, -1}
                        },
                        new int[]{1, 1},    // argument 2: queries
                        new LinkedList<int[]>(  // expected traversal result
                            new[] {
                                new int[]{3, 1, 2},
                                new int[]{2, 1, 3}
                            }
                        )
                    },
                    new object[] {
                        new int[][] {
                            new int[] {2, 3},
                            new int[] {4, -1}, 
                            new int[] {5, -1},  
                            new int[] {6, -1},
                            new int[] {7, 8},
                            new int[] {-1, 9},
                            new int[] {-1, -1},
                            new int[] {10, 11},
                            new int[] {-1, -1},
                            new int[] {-1, -1},
                            new int[] {-1, -1},
                        },
                        new int[] {2, 4},
                        new LinkedList<int[]>(
                            new[] {
                                new int[]{2, 9, 6, 4, 1, 3, 7, 5, 11, 8, 10},
                                new int[]{2, 6, 9, 4, 1, 3, 7, 5, 10, 8, 11}
                            }
                        )
                    },
                    new object[] {
                        new int[][] {
                            new int[] {2, 3},
                            new int[] {4, 5},
                            new int[] {6, -1},
                            new int[] {-1, 7},
                            new int[] {8, 9},
                            new int[]  {10, 11},
                            new int[] {12, 13},
                            new int[] {-1, 14},
                            new int[] {-1, -1},
                            new int[] {15, -1},
                            new int[] {16, 17},
                            new int[] {-1, -1},
                            new int[] {-1, -1},
                            new int[] {-1, -1},
                            new int[] {-1, -1},
                            new int[] {-1, -1},
                            new int[] {-1, -1},
                        },
                        new int[] {2, 3},
                        new LinkedList<int[]>(
                            new[] {
                                new int[]{14, 8, 5, 9, 2, 4, 13, 7, 12, 1, 3, 10, 15, 6, 17, 11, 16},
                                new int[]{9, 5, 14, 8, 2, 13, 7, 12, 4, 1, 3, 17, 11, 16, 6, 10, 15}
                            }
                        )
                    }
                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(DataSource))]
        public void TestSolution(int[][] indexes, int[] queries, LinkedList<int[]> expected)
        {
            var actual = SwapNodes.Solution(indexes, queries);
            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                CollectionAssert.AreEqual(expected.ElementAt(i), actual.ElementAt(i));
            }
        }
    }
}