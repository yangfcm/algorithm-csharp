using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algo.Ds.StackQueue;

namespace Test.Ds.StackQueue
{
  [TestClass]
  public class AnimalQueueTest
  {
    AnimalQueue animalQueue;

    [TestInitialize]
    public void TestInitialize()
    {
      animalQueue = new AnimalQueue();
      animalQueue.Enqueue(Animal.Cat);
      animalQueue.Enqueue(Animal.Dog);
      animalQueue.Enqueue(Animal.Dog);
      animalQueue.Enqueue(Animal.Dog);
      animalQueue.Enqueue(Animal.Cat);
      animalQueue.Enqueue(Animal.Cat);
      animalQueue.Enqueue(Animal.Dog);
    }

    [TestCleanup]
    public void TestCleanup()
    {
      animalQueue = null;
    }

    [TestMethod]
    public void TestDequeueAnimal()
    {
      Assert.AreEqual(animalQueue.DequeueAny().Animal, Animal.Cat);
      Assert.AreEqual(animalQueue.DequeueAny().Animal, Animal.Dog);
      Assert.AreEqual(animalQueue.DequeueAny().Animal, Animal.Dog);
      Assert.AreEqual(animalQueue.DequeueAny().Animal, Animal.Dog);
      Assert.AreEqual(animalQueue.DequeueAny().Animal, Animal.Cat);
      Assert.AreEqual(animalQueue.DequeueAny().Animal, Animal.Cat);
      Assert.AreEqual(animalQueue.DequeueAny().Animal, Animal.Dog);
      Assert.AreEqual(animalQueue.DequeueAny(), null);
    }

    [TestMethod]
    public void TestDequeueCat()
    {
      Assert.AreEqual(animalQueue.DequeueCat().Animal, Animal.Cat);
      Assert.AreEqual(animalQueue.DequeueCat().Animal, Animal.Cat);
      Assert.AreEqual(animalQueue.DequeueCat().Animal, Animal.Cat);
      Assert.AreEqual(animalQueue.DequeueCat(), null);
    }

    [TestMethod]
    public void TestDequeueDog()
    {
      Assert.AreEqual(animalQueue.DequeueDog().Animal, Animal.Dog);
      Assert.AreEqual(animalQueue.DequeueDog().Animal, Animal.Dog);
      Assert.AreEqual(animalQueue.DequeueDog().Animal, Animal.Dog);
      Assert.AreEqual(animalQueue.DequeueDog().Animal, Animal.Dog);
      Assert.AreEqual(animalQueue.DequeueDog(), null);
    }
  }
}