using System.Collections.Generic;

namespace Algo.Ds.Tree.Bst
{
    /// <summary>
    /// Implement three ways to traverse a binary tree: inorder, preorder, postorder
    /// </summary>
    /// <source>
    /// https://www.geeksforgeeks.org/tree-traversals-inorder-preorder-and-postorder/
    /// </source>
    public class BTreeTraverse
    {
        private static List<int> traverseList;

        public static int[] PreOrder(Node node) {
            traverseList = new ();
            DoPreOrder(node);
            return traverseList.ToArray();
        }

        private static void DoPreOrder(Node node) {
            if(node == null) return;
            traverseList.Add(node.Data);
            DoPreOrder(node.Left);
            DoPreOrder(node.Right);
        }

        public static int[] InOrder(Node node) {
            traverseList = new();
            DoInOrder(node);
            return traverseList.ToArray();
        }

        private static void DoInOrder(Node node) {
            if(node == null) return;
            DoInOrder(node.Left);
            traverseList.Add(node.Data);
            DoInOrder(node.Right);
        }

        public static int[] PostOrder(Node node) {
            traverseList = new();
            DoPostOrder(node);
            return traverseList.ToArray();
        }

        private static void DoPostOrder(Node node) {
            if(node == null) return;
            DoPostOrder(node.Left);
            DoPostOrder(node.Right);
            traverseList.Add(node.Data);
        }
    }
}