using System.Collections.Generic;
using System.Linq;

namespace Algo.Ds.Tree.Bst
{
    /// <summary>
    /// For detailed description and examples, refer to the link below.
    /// </summary>
    /// <source>
    /// https://www.hackerrank.com/challenges/swap-nodes-algo/problem
    /// </source>
    public class SwapNodes
    {
        /// <summary>
        ///  Given a 2D array (indexes), return a tree root node that is represented by the array.
        ///  Its root node is always 1 and its leaf nodes are natural numbers: 2, 3, 4, 5 ... -1 means no node for this position.
        /// </summary>
        /// <example>  
        /*
        indexes = [
            [2, 3],
            [4, -1],
            [5, -1],
            [6, -1],
            [7, 8],
            [-1, 9],
            [-1, -1],
            [10, 11],
            [-1, -1],
            [-1, -1],
            [-1, -1],
        ]
        Its corresponding tree should look like:
                 1
                / \
               2   3
              /   /
             4    5
            /    /\
           6    7  8
            \      /\
             9    10 11 
        */
        /// </example>
        /// <param name="indexes"></param>
        /// <returns>Rot node of B-Tree</returns>
        private static Node BuildTree(int[][] indexes)
        {
            var nodeIndexes = new LinkedList<Node[]>();
            var nodesMap = new Dictionary<int, Node>
            {
                { 1, new Node(1) }
            };

            foreach (int[] idx in indexes)
            {
                Node left = null;
                Node right = null;
                if(idx[0] != -1)
                {
                    left = new Node(idx[0]);
                    nodesMap.Add(idx[0], left);
                }

                if(idx[1] != -1)
                {
                    right = new Node(idx[1]);
                    nodesMap.Add(idx[1], right);
                }
                nodeIndexes.AddLast(new Node[] { left, right });
            }

            for (int i = 0; i < nodeIndexes.Count; i++)
            {
                var node = nodesMap[i + 1];
                node.Left = nodeIndexes.ElementAt(i)[0];
                node.Right = nodeIndexes.ElementAt(i)[1];
                if(!nodesMap.ContainsKey(i+1))
                {
                    nodesMap.Add(i + 1, node);
                }
            }
            return nodesMap[1];
        }

        /// <summary>
        /// It actually involves a number of child problems:
        /// 1. Need to create a b-tree from indexes (buildTree)
        /// 2. Create an array for each level of the tree (ListOfDepths)
        /// 3. Inorder traverse a tree (BTreeTraverse.inOrder)
        /// With the above three problems solved, the swap operation itself is easy.
        /// Just iterate nodes throughout a level and swap each node's left child and right child.
        /// </summary>
        /// <param name="indexes"></param>
        /// <param name="queries"></param>
        /// <returns>An array of inorder traversal of the tree after each swap</returns>
        public static LinkedList<int[]> Solution(int[][] indexes, int[] queries)
        {
            var traversalResult = new LinkedList<int[]>();
            Node tree = BuildTree(indexes);
            var levelsList = CreateLevelList.RunAlt(tree);
            int depths = levelsList.Count;
            foreach(int q in queries)
            {
                int k = 1;
                int level = k * q;
                while(level <= depths)
                {
                    var levelNodes = levelsList.ElementAt(level - 1);
                    for (int i = 0; i < levelNodes.Count; i++)
                    {
                        var node = levelNodes.ElementAt(i);
                        var temp = node.Left;
                        node.Left = node.Right;
                        node.Right = temp;
                    }
                    k++;
                    level = k * q;
                }
                var traversalAfterSwap = BTreeTraverse.InOrder(tree);
                traversalResult.AddLast(traversalAfterSwap);
            }
            return traversalResult;
        }
    }
}