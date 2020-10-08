
using System;
/**
* You have two numbers represented by a linked list, where each node contains a single digit.
* The digits are stored in reverse order, such that the 1's digit is at the head of the list
* Write a function that adds the two numbers and returns the sum as a linked list
* e.g. (7 -> 1 -> 6) + (5 -> 9 -> 2) => 617+295 = 912 => 2 -> 1 -> 9
*
* Then suppose the digits are stored in forward order. Repeat the above problem
* e.g. (6 -> 1 -> 7) + (2 -> 9 -> 5) => 617+295 = 912 => 9 -> 1 -> 2
* Difficult: Do not convert to number. How to do that?
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
  }
}