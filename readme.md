# Algorithms Problems and Solutions

## Intro

Interview: Algorithms problems and solutions written in C#, including test cases.

## Algorithms problems content

`/Array`

1. **Chunk Array** Given an array and chunk size, divide the array into many subarrays where each subarray is of length size - `ArrayChunk.cs`
2. **Intersect Arrays** Gompute two arrays' intersection. - `Intersect.cs`
3. **Is Sorted** Test if a given array of numbers is sorted - `IsSorted.cs`
4. **Matrix** Produce a spiral matrix - `Matrix.cs`
5. **Missing Number** Take an unsorted array of unique numbers from to n and return the missing number in the sequence - `Missing.cs`
6. **Moving Zeroes** Move zeroes to the end of an array - `MoveZeroes.cs`
7. **Plus One** Given a non-empty array of digits representing a non-negative integer, plus one to the integer - `PlusOne.cs`
8. **Remove Duplicates** Remove duplicated numbers from an array - `RemoveDuplicates.cs`
9. **Rotate Array** Rotate an array to the right by k steps in place - `RotateArray.cs`
10. **Rotate Image** Rotate an image represented by an n\*n array - `RotateImage.cs`
11. **Two sum(L)** Return indices of the two numbers whose sum equals to a target - `TwoSum.cs`
12. **Valid Sudoku** - Check if a sudoku game is valid - `ValidSudoku.cs`

`/Dynamic`

1. **Max Profit** Given an array with each number representing a stock price for one day, find the max profit - `MaxProfit.cs`
2. **Draw Pyrmid** Print a pyramid shape with n levels using # character and space on its left and right side - `Pyramid.cs`
3. **Draw Steps** Print a step shape with n levels using # character and space(s) on the right - `Steps.cs`

`/Math`

1. **Fibonacci** Print the n-th number in the fibonacci series - `Fibonacci.cs`
2. **Fizzbuzz** Print the numbers from 1 to N. But for multiples of 3 print 'fizz' instead of the number; for multiples of 5, print 'buzz'; for numbers which are multiples of both 3 and 5, print 'fizzbuzz' - `Fizzbuzz.cs`
3. **Is Prime** Test if a given number is a prime - `IsPrime.cs`

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

1. Implement a linked list - `MyLinkedList.js`
2. Get the middle node of a linked list - `MidPoint.js`
3. Check if a linked list is circular - `Circular.js`
4. Return the nth(starting at 0) node from the tail in a linked list - `SearchFromLast.js`
5. Remove duplicates from an unsorted linked list - `RemoveDuplicate.js`
6. Partition a linked list - `Partition.js`
7. Sum two linked list - `SumLists.js`

`/Ds/StackQueue`

1. Implement Queue class's Enqueue(), Dequeue() and Peek() method ONLY using two Stacks - `QueueFromStack.cs`
2. "Weave" two queues - `Weave.cs`
3. Get the minimum number in a stack - `GetMin.js`
4. Sort a stack - `SortStack.js`
5. Implement an animal queue - `AnimalQueue.js`
6. Implement a stack of plates - `SetOfStacks.js`

`/Ds/Tree`

1. Implement a tree and using BFS and DFS to traverse a tree - `Tree.cs`
2. Get the width of each level of a tree - `Tree.cs`
3. Implement a binary search tree - `BinarySarchTree.cs`
4. Validate the binary search tree - `BinarySarchTree.cs`
5. Create a binary search tree with minimal height based on a ascend-sorted array - `minimalTree.cs`
6. Create an array of all the nodes at each depth. - `ListOfDepths.cs`

`/Ds/Graph`

1. Implement a graph class and its relevant methods, including DFS and BFS - `Graph.js`

## Development Environment

- .Net core SDK 3.0 - Need to [download](https://dotnet.microsoft.com/download) and install it before running
- C# 8.0

## How to run

Under project root directory: `dotnet test ./test` and see the test outcome.
