# Algorithms Problems and Solutions

## Intro

Algorithms, Data Structure problems and solutions written in C#, including test cases.

## Content

### Algorithm

- [Array](./Algo/Array)
- [Assorted](./Algo/Assorted)
- [Dynamic](./Algo/Dynamic)
- [Math](./Algo/Mathematics)
- [String](./Algo/String)

### Data Structure

- [Stack and Queue](./Algo/Ds/StackQueue)
- [Linked List](./Algo/Ds/LinkedList)
- [Hash Table](./Algo/Ds/Hash)
- [Tree](./Algo/Ds/Tree)
- [Graph](./Algo/Ds/Graph)

### Sorting

- [Sorting](./Algo/Sorting)

### Searching

- [Searching](./Algo/Searching)

## Development Environment

- .Net core SDK 6.0 - Need to [download](https://dotnet.microsoft.com/download) and install it before running
- C# 8.0

## How to run

Under project root directory:

1. Run all tests

```
dotnet test
```

2. Run a particular test

```
dotnet test --filter ClassName=Test.Algo.Arr.ArrayChunkTest
```

3. Run a set of tests that contain the keyword

```
# Run all test cases that in 'Greedy' directory
dotnet test --filter ClassName~Greedy

# Run test cases for ArrayChunk
dotnet test --filter ClassName~ArrayChunk
```
