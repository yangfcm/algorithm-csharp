using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Ds.Tree.Bst;

namespace Test.Ds.Tree.Bst
{
    [TestClass]
    public class BTreeTraverseTest
    {
        private Node root1;
        private Node root2;

        [TestInitialize]
        public void TestInitialize()
        {
            root1 = new (1);
            root1.Left = new Node(2);
            root1.Right = new Node(3);
            root1.Left.Left = new Node(4);
            root1.Left.Right = new Node(5);

            root2 = new(25);
            root2.Add(15);
            root2.Add(50);
            root2.Add(10);
            root2.Add(22);
            root2.Add(35);
            root2.Add(70);
            root2.Add(4);
            root2.Add(12);
            root2.Add(18);
            root2.Add(24);
            root2.Add(31);
            root2.Add(44);
            root2.Add(66);
            root2.Add(90);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            root1 = null;
            root2 = null;
        }

        [TestMethod]
        public void TestPreOrder()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 4, 5, 3 }, BTreeTraverse.PreOrder(root1));
            CollectionAssert.AreEqual(new int[] { 25, 15, 10, 4, 12, 22, 18, 24, 50, 35, 31, 44, 70, 66, 90 }, BTreeTraverse.PreOrder(root2));
        }

        [TestMethod]
        public void TestInOrder()
        {
            CollectionAssert.AreEqual(new int[] { 4, 2, 5, 1, 3 }, BTreeTraverse.InOrder(root1));
            CollectionAssert.AreEqual(new int[] { 4, 10, 12, 15, 18, 22, 24, 25, 31, 35, 44, 50, 66, 70, 90 }, BTreeTraverse.InOrder(root2));
        }

        [TestMethod]
        public void TestPostOrder()
        {
            CollectionAssert.AreEqual(new int[] { 4, 5, 2, 3, 1 }, BTreeTraverse.PostOrder(root1));
            CollectionAssert.AreEqual(new int[] { 4, 12, 10, 18, 24, 22, 15, 31, 44, 35, 66, 90, 70, 50, 25 }, BTreeTraverse.PostOrder(root2));
        }
    }
}