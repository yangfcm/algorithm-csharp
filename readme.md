# Algorithms Problems and Solutions

## Intro

Interview: Algorithms problems and solutions written in C#, including test cases.

## Algorithms problems content

`/Array`

- **Chunk Array** Given an array and chunk size, divide the array into many subarrays where each subarray is of length size - `ArrayChunk.cs`
- **Intersect Arrays** Gompute two arrays' intersection. - `Intersect.cs`
- **Is Sorted** Test if a given array of numbers is sorted - `IsSorted.cs`
- **Matrix** Produce a spiral matrix - `Matrix.cs`
- **Missing Number** Take an unsorted array of unique numbers from to n and return the missing number in the sequence - `Missing.cs`
- **Moving Zeroes** Move zeroes to the end of an array - `MoveZeroes.cs`
- **Plus One** - Given a non-empty array of digits representing a non-negative integer, plus one to the integer - `PlusOne.cs`
- **Remove Duplicates** - Remove duplicated numbers from an array - `RemoveDuplicates.cs`
- **Rotate Array** - Rotate an array to the right by k steps in place - `RotateArray.cs`
- **Rotate Image** - Rotate an image represented by an n\*n array - `RotateImage.cs`
- **Two sum(L)** Return indices of the two numbers whose sum equals to a target - `TwoSum.cs`
- **Valid Sudoku** - Check if a sudoku game is valid - `ValidSudoku.cs`

`/Dynamic`

- **Max Profit** - Given an array with each number representing a stock price for one day, find the max profit - `MaxProfit.cs`
- **Draw Pyrmid** Print a pyramid shape with n levels using # character and space on its left and right side - `Pyramid.cs`
- **Draw Steps** Print a step shape with n levels using # character and space(s) on the right - `Steps.cs`

`/Math`

- **Fibonacci** Print the n-th number in the fibonacci series - `Fibonacci.cs`
- **Fizzbuzz** Print the numbers from 1 to N. But for multiples of 3 print 'fizz' instead of the number; for multiples of 5, print 'buzz'; for numbers which are multiples of both 3 and 5, print 'fizzbuzz' - `Fizzbuzz.cs`
- **Is Prime** Test if a given number is a prime - `IsPrime.cs`

`/String`

- **Anagrams** Check to see if two strings are anagrams of each other - `Anagrams.cs`
- **Capitalize** Capitalize each word in a string - `Capitalize.cs`
- **Is Balanced** Test if curly braces in a string is matched - `IsBalanced.cs`
- **Max Character** Get the character that most commonly appears in a given string - `MaxChar.cs`
- **Palindrome** - `Palindrome.cs`
- **Remove Vowels(L)** Remove vowels of a string - `RemoveVowels.cs`
- **Reverse Integer** Reverse an integer - `ReverseInt.cs`
- **Reverse String** Reverse a string - `ReverseStr.cs`
- **How Many Vowels** Count the number of vowels used in a string - `Vowels.cs`

`/Sorting`

- **Sorting** Implement the three most common sorting methods - `Sorting.cs`

`/Ds`

- **QueueFromStack** Implement Queue class's Enqueue(), Dequeue() and Peek() method ONLY using two Stacks - `QueueFromStack.cs`
- **Weave** "Weave" two queues - `Weave.cs`

## Development Environment

- .Net core SDK 3.0 - Need to [download](https://dotnet.microsoft.com/download) and install it before running
- C# 8.0

## How to run

Under project root directory: `dotnet test ./test` and see the test outcome.
