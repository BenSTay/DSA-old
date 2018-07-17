using System;
using Xunit;
using TreeIntersection;
using Trees.Classes;
using Hashtables.Classes;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TreeIntersectionTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestTreeHasMatches()
        {
            string string1 = "It was the best of times, it was the worst of times.";
            string string2 = "Sign o' the times mess with your mind";

            string[] string1Words = Regex.Split(string1.ToLower(), @"\W+");
            string[] string2Words = Regex.Split(string2.ToLower(), @"\W+");

            Tree<string> tree1 = Program.GenerateTree(string1Words);
            Tree<string> tree2 = Program.GenerateTree(string2Words);

            List<string> matches = Program.TreeIntersection(tree1, tree2);

            Assert.Contains("the", matches);
            Assert.Contains("times", matches);
        }

        [Fact]
        public void TestTreeHasNoMatches()
        {
            string string1 = "It was the best of times, it was the worst of times.";
            string string2 = "Let's go crazy, let's get nuts";

            string[] string1Words = Regex.Split(string1.ToLower(), @"\W+");
            string[] string2Words = Regex.Split(string2.ToLower(), @"\W+");

            Tree<string> tree1 = Program.GenerateTree(string1Words);
            Tree<string> tree2 = Program.GenerateTree(string2Words);

            List<string> matches = Program.TreeIntersection(tree1, tree2);

            Assert.Empty(matches);
        }

        [Fact]
        public void TestIdenticalTrees()
        {
            string string1 = "It was the best of times, it was the worst of times.";

            string[] string1Words = Regex.Split(string1.ToLower(), @"\W+");

            Tree<string> tree1 = Program.GenerateTree(string1Words);

            List<string> matches = Program.TreeIntersection(tree1, tree1);

            foreach(string word in string1Words)
            {
                Assert.Contains(word, matches);
            }
        }
    }
}
