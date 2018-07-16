using System;
using Xunit;
using Hashtables.Classes;
using Hashtables;

namespace HashtableTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestContains()
        {
            Hashtable<int> hashtable = Program.MakeTable();
            Assert.True(hashtable.Contains("Cat"));
        }

        [Fact]
        public void TestAdd()
        {
            Hashtable<int> hashtable = Program.MakeTable();
            hashtable.Add("Iguana", 49);
            Assert.True(hashtable.Contains("Iguana"));
        }

        [Theory]
        [InlineData("ABC", "CBA")]
        [InlineData("dog", "god")]
        public void TestCollision(string key1, string key2)
        {
            Hashtable<int> hashtable = new Hashtable<int>();
            hashtable.Add(key1, 1);
            hashtable.Add(key2, 2);
            Assert.Equal(hashtable.GetHash(key1), hashtable.GetHash(key2));
            Assert.True(hashtable.Contains(key1) && hashtable.Contains(key2));
        }
    }
}
