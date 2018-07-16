# Hashtable
**Author**: Benjamin Taylor  
**Version**: 1.0.0

## Overview
<!-- What is a hashtable -->
A hashtable is a data structure where data is stored as key value pairs, and are stored in a row of the table determined by the result of a hashing algorithm.
![Graph](https://github.com/btaylor93/Data-Structures-and-Algorithms/raw/master/assets/hashtable.png)
<!-- How I made this hashtable -->
This implementation uses an array of KeyValuePair objects of size 1024 as it's table, where the key is a string and the value is a generic type. The Hashtable class contains 4 methods: an Add method that returns void and inserts a KeyValuePair into the array (if the key does not already exist within the table), a Find method that returns the value associated with a given key if the key is found in the hashtable, a Contains method that returns a boolean representing whether or not a given key is held within the hashtable, and a GetHash method that returns an integer based on the sum of the characters in a given string multiplied by an arbitrary value and modulused by 1024.  
<!-- What hashtables are used for -->
Hashtables are often used for databases, because they allow for quick insertion and retrieval of information. You could use a hashtable for a database of users for a website, or for a resource database to be used by installation/patching software.

## Getting Started
1. Create a fork of this repository, and clone your fork to your device.  
2. Open the solution file (Hashtable.sln) in Visual Studio.
3. To run the app, click the green arrow button labeled "Start".
4. For testing, navigate to the HashtableTests project using the Solution Explorer.
5. To run the tests, press CTRL+R or navigate to Tests > Run > All Tests in the top-level menu.

## Architecture
**Languages Used**: C# 7.0 (.NET Core 2.1)  

Written with Visual Studio Community 2017.

## Change Log
07-16-2018 10:58am - Initial version.