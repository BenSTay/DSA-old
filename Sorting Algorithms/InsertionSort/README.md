# Insertion Sort
**Author**: Benjamin Taylor  
**Version**: 1.0.0

## Overview
<!-- Description -->
Insertion Sort is a simple sorting algorithm that builds a sorted array one item at a time.
![Graph](https://github.com/btaylor93/Data-Structures-and-Algorithms/raw/master/assets/insertionsort.png)
<!-- Implementation Notes -->
This implementation uses a nested for loop to perform the sort, starting at the second element in the input array. For each element in the array, it compares the value of the element to the value of the previous element, swapping their positions if the current element has a lesser value than the previous element. This continues until the previous element has a equal or lesser value to the current element, or the start of the array is reached. This algorithm has a time efficiency of O(N^2), and a space efficiency of O(N) (because it is creating a new array).

## Getting Started
1. Create a fork of this repository, and clone your fork to your device.  
2. Open the solution file (InsertionSort.sln) in Visual Studio.
3. To run the app, click the green arrow button labeled "Start".
4. For testing, navigate to the InsertionSortTests project using the Solution Explorer.
5. To run the tests, press CTRL+R or navigate to Tests > Run > All Tests in the top-level menu.

## Architecture
**Languages Used**: C# 7.0 (.NET Core 2.1)  

Written with Visual Studio Community 2017.

## Change Log
07-28-2018 6:39pm - Initial version.