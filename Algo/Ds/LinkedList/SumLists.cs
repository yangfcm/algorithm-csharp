
using System;
/**
* You have two numbers represented by a linked list, where each node contains a single digit.
* The digits are stored in reverse order, such that the 1's digit is at the head of the list
* Write a function that adds the two numbers and returns the sum as a linked list
* e.g. (7 -> 1 -> 6) + (5 -> 9 -> 2) => 617+295 = 912 => 2 -> 1 -> 9
*
* Then suppose the digits are stored in forward order. Repeat the above problem
* e.g. (6 -> 1 -> 7) + (2 -> 9 -> 5) => 617+295 = 912 => 9 -> 1 -> 2
* Do not convert it to number and consider two lists have different length.
*/
namespace Algo.Ds.LinkedList
{
  public class SumLists
  {
    static public MyLinkedList<int> SumRev(MyLinkedList<int> list1, MyLinkedList<int> list2)
    {
      int num1 = ConvertListToNumber(list1, -1);
      int num2 = ConvertListToNumber(list2, -1);
      int sum = num1 + num2;
      return ConvertNumberToList(sum, -1);
    }

    static public MyLinkedList<int> SumFwd(MyLinkedList<int> list1, MyLinkedList<int> list2)
    {
      int num1 = ConvertListToNumber(list1, 1);
      int num2 = ConvertListToNumber(list2, 1);
      int sum = num1 + num2;
      return ConvertNumberToList(sum, 1);
    }

    /** Help function 1:
    * Convert a linked list to a number, if direction is a number bigger than or equal 0, then convert it forwardly.
    * If direction is a number less than 0, convert it reversely.
    * e.g. list (7 -> 1 -> 6) direction 1 => 716, list (7 -> 1 -> 6) direction -1 => 617
    * @param {LinkedList} list
    * @param {number} direction
    */
    private static int ConvertListToNumber(MyLinkedList<int> list, int direction = 1)
    {
      string numberStr = "";
      list.ForEach((node, counter) =>
      {
        numberStr = direction >= 0 ?
          numberStr + node.Data.ToString() :
          node.Data.ToString() + numberStr;
      });
      return Convert.ToInt32(numberStr);
    }

    /** Help function 2:
    * Convert a number to a linked list, if direction is a number bigger than or equal 0, then convert it forwardly.
    * If direction is a number less than 0, convert it reversely.
    * e.g. number 912 direction 1 => 9 -> 1 -> 2, direction -1 => 2 -> 1 -> 9
    * @param {number} number
    * @param {number} direction
    */
    private static MyLinkedList<int> ConvertNumberToList(int number, int direction = 1)
    {
      string numberStr = number.ToString();
      MyLinkedList<int> list = new MyLinkedList<int>();
      foreach (char numChar in numberStr)
      {
        if (direction >= 0)
        {
          list.AddLast(int.Parse(numChar.ToString()));
        }
        else
        {
          list.AddFirst(int.Parse(numChar.ToString()));
        }
      }
      return list;
    }

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