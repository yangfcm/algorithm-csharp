using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Ds.Hash;

namespace Test.Ds.Hash
{
  [TestClass]
  public class HashTableConstructorTest
  {
    HashTable hashTable;

    [TestInitialize]
    public void TestInitialize()
    {
      hashTable = new HashTable();
    }

    [TestCleanup]
    public void Cleanup()
    {
      hashTable = null;
    }

    [TestMethod]
    public void TestConstructor()
    {
      Assert.IsNotNull(hashTable);
      Assert.AreEqual(hashTable.GetCount(), 0);
      Assert.AreEqual(hashTable.GetSize(), 8);
      var table = hashTable.GetTable();
      for (int i = 0; i < table.Length; i++)
      {
        Assert.IsNull(table[i]);
      }
    }
  }

  [TestClass]
  public class HashTableTest
  {
    HashTable hashTable;

    [TestInitialize]
    public void TestInitialize()
    {
      hashTable = new HashTable();
      hashTable.Put("Alex", 92);
      hashTable.Put("Bob", 82);
      hashTable.Put("Carl", 70);
    }

    [TestCleanup]
    public void Cleanup()
    {
      hashTable = null;
    }

    [TestMethod]
    public void TestAddNode()
    {
      var valueAdded = hashTable.Put("David", 80);
      Assert.AreEqual(valueAdded, 80);
      Assert.AreEqual(hashTable.GetCount(), 4);
    }

    [TestMethod]
    public void TestOverridNode()
    {
      var newValue = hashTable.Put("Alex", 99);
      Assert.AreEqual(hashTable.Get("Alex"), 99);
    }

    [TestMethod]
    public void TestGetNode()
    {
      Assert.AreEqual(hashTable.Get("Alex"), 92);
      Assert.AreEqual(hashTable.Get("Bob"), 82);
      Assert.AreEqual(hashTable.Get("Carl"), 70);
      Assert.IsNull(hashTable.Get("David"));
    }

    [TestMethod]
    public void TestRemoveNode()
    {
      Assert.AreEqual(hashTable.Remove("Bob"), 82);
      Assert.AreEqual(hashTable.GetCount(), 2);
      Assert.IsNull(hashTable.Remove("David"));
    }

    [TestMethod]
    public void TestResize()
    {
      hashTable.Resize(10);
      Assert.AreEqual(hashTable.GetSize(), 10);
      Assert.AreEqual(hashTable.Get("Alex"), 92);
      Assert.AreEqual(hashTable.Get("Bob"), 82);
      Assert.AreEqual(hashTable.Get("Carl"), 70);
    }
  }
}