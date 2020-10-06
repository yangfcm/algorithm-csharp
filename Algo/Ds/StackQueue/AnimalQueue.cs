using System.Collections.Generic;

/**
 * An animal queue, which holds only dogs and cats, operates on a strictly "fist in, first out" basis.
 * People ust adopt either the first of all animals at the shelter,
 * or they can select whether they would prefer the first dog or the first cat(cannot select a specific animal they like)
 * Create the data structures to maintain this system and implement operations such as enqueue, dequeueAny, dequeueDog, dequeueCat.
 */
namespace Algo.Ds.StackQueue
{
  public enum Animal
  {
    Dog,
    Cat
  };

  public class AnimalData
  {
    public Animal Animal { get; set; }
    public int Order { get; set; }

    public AnimalData(Animal animal, int order)
    {
      this.Animal = animal;
      this.Order = order;
    }
  }

  public class AnimalQueue
  {
    private int order;
    private Queue<AnimalData> dogQueue;
    private Queue<AnimalData> catQueue;
    public AnimalQueue()
    {
      this.order = 0;
      this.dogQueue = new Queue<AnimalData>();
      this.catQueue = new Queue<AnimalData>();
    }

    public void Enqueue(Animal data)
    {
      if (data == Animal.Cat)
      {
        this.catQueue.Enqueue(new AnimalData(data, this.order));
      }
      else if (data == Animal.Dog)
      {
        this.dogQueue.Enqueue(new AnimalData(data, this.order));
      }
      this.order++;
    }

    public AnimalData DequeueDog()
    {
      return dogQueue.Peek() != null ? dogQueue.Dequeue() : null;
    }

    public AnimalData DequeueCat()
    {
      return catQueue.Peek() != null ? catQueue.Dequeue() : null;
    }

    public AnimalData DequeueAny()
    {
      var firstCat = catQueue.Peek();
      var firstDog = dogQueue.Peek();
      if (firstCat == null && firstDog == null) return null;
      if (firstCat != null && firstDog == null) return catQueue.Dequeue();
      if (firstDog != null && firstCat == null) return dogQueue.Dequeue();
      if (firstCat != null && firstDog != null)
      {
        return firstCat.Order < firstDog.Order ? catQueue.Dequeue() : dogQueue.Dequeue();
      }
      return null;
    }
  }
}