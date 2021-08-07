# Algorithms Problems and Solutions

## Intro

Interview: Algorithms problems and solutions written in C#, including test cases.

## Algorithms problems content

`/array` - Problems and solutions about arrays.

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

1. **Anagrams** Check to see if two strings are anagrams of each other - `Anagrams.cs`
2. **Capitalize** Capitalize each word in a string - `Capitalize.cs`
3. **Is Balanced** Test if curly braces in a string is matched - `IsBalanced.cs`
4. **Max Character** Get the character that most commonly appears in a given string - `MaxChar.cs`
5. **Palindrome** `Palindrome.cs`
6. **Check Palindrome Permutation** Check if a string is a permutation of a palindrome - `PalindromePermutation.cs`
7. **Remove Vowels(L)** Remove vowels of a string - `RemoveVowels.cs`
8. **Reverse Integer** Reverse an integer - `ReverseInt.cs`
9. **Reverse String** Reverse a string - `ReverseStr.cs`
10. **How Many Vowels** Count the number of vowels used in a string - `Vowels.cs`
11. **Check Permutation** Check two strings are permutation - `CheckPermutation.cs`
12. **Check Unique Characters** Determine if a string has all unique characters - `IsUnique.cs`
13. **Check One Away** Check if one string is one edit away from the other string - `OneAway.cs`
14. **Check String Rotation** Check if one string is the rotation of the other string, using isSubString function - `StringRotation.cs`
15. **Compress String** Compress a string - `StringCompression.cs`

## Sorting

`/Sorting`

1. **Sorting** Implement the three most common sorting methods - `Sorting.cs`

## Data structure

`/Ds/Hash`

1. **Hash Table** Implement a hash table - `HashTable.cs`

`/Ds/LinkedList`

1. Implement a linked list - `MyLinkedList.cs`
2. Get the middle node of a linked list - `MidPoint.cs`
3. Check if a linked list is circular - `Circular.cs`
4. Return the nth(starting at 0) node from the tail in a linked list - `SearchFromLast.cs`
5. Remove duplicates from an unsorted linked list - `RemoveDuplicate.cs`
6. Partition a linked list - `Partition.cs`
7. Sum two linked list - `SumLists.cs`

`/Ds/StackQueue`

1. Implement Queue class's Enqueue(), Dequeue() and Peek() method ONLY using two Stacks - `QueueFromStack.cs`
2. "Weave" two queues - `Weave.cs`
3. Get the minimum number in a stack - `GetMin.cs`
4. Sort a stack - `SortStack.cs`
5. Implement an animal queue - `AnimalQueue.cs`
6. Implement a stack of plates - `SetOfStacks.cs`

`/Ds/Tree`

1. Implement a tree and using BFS and DFS to traverse a tree - `Tree.cs`
2. Get the width of each level of a tree - `Tree.cs`
3. Implement a binary search tree - `BinarySarchTree.cs`
4. Validate the binary search tree - `BinarySarchTree.cs`
5. Create a binary search tree with minimal height based on a ascend-sorted array - `minimalTree.cs`
6. Create an array of all the nodes at each depth. - `ListOfDepths.cs`

`/Ds/Graph`

1. Implement a graph class and its relevant methods, including DFS and BFS - `Graph.cs`

## Searching

`/Searching`

1. Implement linear search - `LinearSearch.cs`
2. Implement binary search - `BinarySearch.cs`
3. Implmenet jump search - `JumpSearch.cs`
4. Implement interpolation search - `InterpolationSearch.cs`
5. Implement exponential search - `ExponentialSearch.cs`

## Development Environment

- .Net core SDK 3.0 - Need to [download](https://dotnet.microsoft.com/download) and install it before running
- C# 8.0

## How to run

Under project root directory: `dotnet test ./test` and see the test outcome.
