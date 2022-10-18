using System.Collections.Generic;
using System;

/**
 * Implement a hash table.
 */
namespace Algo.Ds.Hash
{
  public class HashTable
  {
    List<(string, dynamic)>[] Table;
    int Count;  // How many key-value pairs in the hash table

    int Size; // The size of hash table
    public HashTable()
    {
      Count = 0;
      Size = 8;
      Table = new List<(string, dynamic)>[Size];
    }

    public int GetCount()
    {
      return Count;
    }

    public int GetSize()
    {
      return Size;
    }

    public List<(string, dynamic)>[] GetTable()
    {
      return Table;
    }

    /**
     * Hash: Given a key(string) and hash it
     */
    int Hash(string key)
    {
      int hash = 0;
      for (int i = 0; i < key.Length; i++)
      {
        char letter = key[i];
        hash = (hash << 5) + (int)letter;
        hash = (hash & hash) % Size;
      }
      return hash;
    }

    /**
     * Add a key-value pair into the hash table
     */
    public dynamic Put(string key, dynamic value)
    {
      int index = Hash(key);
      List<(string, dynamic)> bucket = Table[index];
      if (bucket == null)
      {
        // If bucket doesn't exist, create one.
        bucket = new List<(string, dynamic)>();
        Table[index] = bucket;
      }

      // Iterate through the bucket to see if there are any conflicting key in the bucket
      // If there's any, override them
      for (int i = 0; i < bucket.Count; i++)
      {
        (string key, dynamic value) node = bucket[i];
        if (node.key == key)
        {
          bucket[i] = (key, value);
          return value;
        }
      }

      // Add a new key-value pair into bucket
      bucket.Add((key, value));
      Count++;

      // Now that a new key-value pair is added, check to see if table's size should be increased
      if (Count > Size * .75)
      {
        Resize(Size * 2);
      }
      return value;
    }

    /**
     * Given a key, get the value associated with the key in the hash table
     */
    public dynamic Get(string key)
    {
      int index = Hash(key);
      var bucket = Table[index];
      if (bucket == null)
      {
        return null;
      }
      foreach ((string key, dynamic value) node in bucket)
      {
        if (node.key == key)
        {
          return node.value;
        }
      }
      return null;
    }

    /**
     * Given a key, remove the node associated with the key
     */
    public dynamic Remove(string key)
    {
      int index = Hash(key);
      var bucket = Table[index];
      if (bucket == null)
      {
        return null;
      }
      for (int i = 0; i < bucket.Count; i++)
      {
        (string key, dynamic value) node = bucket[i];
        if (node.key == key)
        {
          bucket.RemoveAt(i);
          Count--;
          if (Count < Size * .25)
          {
            Resize(Size / 2);
          }
          return node.value;
        }
      }
      return null;
    }

    /**
     * Resize the hash table
     */
    public void Resize(int newSize)
    {
      var oldTable = Table;
      Size = newSize;
      Count = 0;
      Table = new List<(string, dynamic)>[Size];
      for (int k = 0; k < oldTable.Length; k++)
      {
        List<(string, dynamic)> bucket = oldTable[k];
        Console.WriteLine(k);
        if (bucket == null)
        {
          continue;
        }
        for (int i = 0; i < bucket.Count; i++)
        {
          (string key, dynamic value) = bucket[i];
          this.Put(key, value);
        }
      }
    }
  }
}