
using System;
/**
* You have two numbers represented by a linked list, where each node contains a single digit.
* The digits are stored in reverse order, such that the 1's digit is at the head of the list
* Write a function that adds the two numbers and returns the sum as a linked list
* Example: (7 -> 1 -> 6) + (5 -> 9 -> 2) => 617+295 = 912 => 2 -> 1 -> 9
*/
namespace Algo.Ds.LinkedList
{
  public class SumLists
  {
    static public MyLinkedList<int> Run(MyLinkedList<int> list1, MyLinkedList<int> list2)
    {
      var sumList = new MyLinkedList<int>();
      int count1 = list1.Count;
      int count2 = list2.Count;
      int maxCount = count1 > count2 ? count1 : count2;
      var node1 = list1.Head;
      var node2 = list2.Head;

      for (int i = 0; i < maxCount; i++) {
          int digit1 = node1 == null ? 0 : node1.Data;
          int digit2 = node2 == null ? 0 : node2.Data;
          var lastDigit = sumList.FindLast() == null ? 0 : sumList.FindLast().Data;
          sumList.RemoveLast();
          int digitSum = digit1 + digit2 + lastDigit;
          sumList.AddLast(digitSum % 10);
          sumList.AddLast(digitSum / 10);

          if(node1 != null) node1 = node1.Next;
          if(node2 != null) node2 = node2.Next;
        }
        return sumList;
      }
  }
}