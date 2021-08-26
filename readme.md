# Algorithms Problems and Solutions

## Intro

Interview: Algorithms problems and solutions written in C#, including test cases.

## Algorithms problems content

`/Array` - Problems and solutions about arrays.

1. `ArrayChunk.cs`

   Chunk Array: Given an array and chunk size, divide the array into many subarrays where each subarray is of length size.

2. `Intersect.cs`

   Compute two arrays' intersection.

3. `IsSorted.cs`

   Test if a given array of numbers is sorted.

4. `Matrix.js`

   Produce a spiral matrix.

5. `Missing.js`

   Missing Number: Take an unsorted array of unique numbers from to n and return the missing number in the sequence.

6. `MovingZeroes.js`

   Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.

7. `PlusOne.js`

   Given a non-empty array of digits representing a non-negative integer, plus one to the integer.

8. `RemoveDuplicates.js`

   Given an array with sorted numbers, remove duplicated numbers in-place.

9. `RotateArray.js`

   Given an array, rotate the array to the right by k steps in-place.

10. `RotateImage.js`

    Rotate an image represented by a n\*n array by 90 degrees (clockwise).

11. `SockMerchant.js`

    Find out how many pairs of socks with matching colors(represented by numbers in an array).

12. `TwoSum.js`

    Return indices of the two numbers whose sum equals to a target.

13. `ValidSudoku.js`

    Determine if a 9x9 Sudoku board is valid.

`/Assorted`

1. `MaxProfit.cs`

   Given an array with each number representing a stock price for one day, find the max profit

2. `Pyramid.cs`

   Print a pyramid shape with n levels using # character and space on its left and right side

3. `Steps.cs`

   Print a step shape with n levels using # character and space(s) on the right

`/Dynamic`

1. `GridTraveler.cs`

   A traveler begins in the top-left corner of a m x n grid and ends in the bottom-right corner. You may only move down or right. Calculate how many routes you can travel to the goal.

2. `CanSum.cs`

   Given a target number and an array of numbers. Write algorithm to indicate if it is possible to generate the target sum using the numbers from the array. You may use an element of the array as many times as needed.

3. `HowSum.cs`

   Follow up the previous problem: return an array containing one combination of the numbers that add up to exactly the target number.

4. `BestSum.cs`

   Follow up the prvious problem: return an array that has the shortest combination of the numbers.

5. `CanConstruct.cs`

   Given a target string and an array of strings. Write algorithm to indicate if it is possible to construct the target string by concatenating elements of the strings array.

6. `CountConstruct.cs`

   Follow up the previous problem: return the number of ways to construct the target string by concatenating elements of the strings array.

7. `AllConstruct.cs`

   Follow up the previous problem: return all the ways to construct the target string by concatenating elements of the strings array.

`/Mathematics`

1. `Fibonacci.cs`

   Print the n-th number in the fibonacci series

2. `Fizzbuzz.cs`

   Fizzbuzz: print the numbers from 1 to N.<br>
   But for multiples of 3 print 'fizz' instead of the number;<br>
   for multiples of 5, print 'buzz';<br>
   for numbers which are multiples of both 3 and 5, print 'fizzbuzz'<br>

3. `IsPrime.cs`

   Test if a given number is a prime(质数)

`/String`

1. `Anagrams.cs`

   Check to see if two strings are anagrams of each other

2. `Capitalize.cs`

   Capitalize each word in a string

3. `CheckPermutation.cs`

   Check two strings are permutation

4. `IsBalanced.cs`

   Test if curly braces in a string is matched

5. `IsUnique.cs`

   Determine if a string has all unique characters

6. `MakeAnagrams.cs`

   Determine the minimum number of characters deletions required to make two strings anagrams.

7. `MaxChar.cs`

   Get the character that most commonly appears in a given string

8. `OneAway.cs`

   Check if one string is one edit away from the other string

9. `Palindrome.cs`

   Test a string is a palindrome(its reversed string is exactly the same as itself)

10. `PalindromePermutation.cs`

    Check if a string is a permutation of a palindrome

11. `RemoveVowels.cs`

    Remove vowels of a string

12. `ReverseInt.cs`

    Reverse an integer

13. `ReverseStr.cs`

    Reverse a string

14. `StringCompression.cs`

    Compress a string

15. `StringRotation.cs`

    Check if one string is the rotation of the other string, using isSubString function

16. `Vowels.cs`

    Count the number of vowels used in a string

## Sorting

`/Sorting`

1. **Sorting** Implement the three most common sorting methods - `Sorting.cs`

## Data structure

`/Ds/Hash`

1. `HashTable.cs` Implement a hash table

`/Ds/LinkedList`

1. `MyLinkedList.cs`

   Implement a linked list

2. `MidPoint.cs`

   Get the middle node of a linked list

3. `Circular.cs`

   Check if a linked list is circular

4. `SearchFromLast.cs`

   Return the nth(starting at 0) node from the tail in a linked list

5. `RemoveDuplicate.cs`

   Remove duplicates from an unsorted linked list

6. `Partition.cs`

   Partition a linked list

7. `SumLists.cs`

   Sum two linked list

`/Ds/StackQueue`

1. `AnimalQueue.cs`

   Implement an animal queue

2. `GetMin.cs`

   Get the minimum number in a stack

3. `QueueFromStack.cs`

   Implement Queue class's Enqueue(), Dequeue() and Peek() method ONLY using two Stacks

4. `SetOfStacks.cs`

   Implement a stack of plates

5. `SortStack.cs`

   Sort a stack

6. `Weave.cs`

   "Weave" two queues

`/Ds/Tree`

1. `Tree.cs`

   Implement a tree and using BFS and DFS to traverse a tree incl. get the width of each level of a tree

2. `BinarySarchTree.cs`

   Implement a binary search tree incl. validate a binary search tree

3. `minimalTree.cs`

   Create a binary search tree with minimal height based on a ascend-sorted array

4. `ListOfDepths.cs`

   Create an array of all the nodes at each depth.

`/Ds/Graph`

1. `Graph.cs`

   Implement a graph class and its relevant methods, including DFS and BFS

## Searching

`/Searching`

1. `LinearSearch.cs`

   Implement linear search

2. `BinarySearch.cs`

   Implement binary search

3. `JumpSearch.cs`

   Implmenet jump search

4. `InterpolationSearch.cs`

   Implement interpolation search

5. `ExponentialSearch.cs`

   Implement exponential search

## Development Environment

- .Net core SDK 5.0 - Need to [download](https://dotnet.microsoft.com/download) and install it before running
- C# 8.0

## How to run

Under project root directory: `dotnet test ./test` and see the test outcome.
