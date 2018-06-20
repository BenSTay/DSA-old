using FIFOAnimalShelter.Classes;
using System;
using Xunit;

namespace AnimalShelterTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestEnqueueCat()
        {
            AnimalShelter shelter = new AnimalShelter(new Dog("Moby"));
            shelter.Enqueue(new Cat("Boots"));
            Assert.Equal("Boots", shelter.Peek().Next.Name);
        }

        [Fact]
        public void TestEnqueueDog()
        {
            AnimalShelter shelter = new AnimalShelter(new Cat("Boots"));
            shelter.Enqueue(new Dog("Moby"));
            Assert.Equal("Moby", shelter.Peek().Next.Name);
        }

        [Fact]
        public void TestEnqueueHorse()
        {
            AnimalShelter shelter = new AnimalShelter(new Dog("Moby"));
            Assert.Throws<Exception>(() => shelter.Enqueue(new Horse("Bojack")));
        }

        [Theory]
        [InlineData("dog", "Moby")]
        [InlineData("cat", "Boots")]
        [InlineData("", "Moby")]
        public void TestDequeue(string pref, string expected)
        {
            AnimalShelter shelter = new AnimalShelter(new Dog("Moby"));
            shelter.Enqueue(new Cat("Boots"));
            Assert.Equal(expected, shelter.Dequeue(pref).Name);
        }
        
        [Fact]
        public void TestFindFirstDog()
        {
            AnimalShelter shelter = new AnimalShelter(new Cat("Boots"));
            shelter.Enqueue(new Dog("Moby"));
            Assert.Equal("Moby", shelter.FindFirst(typeof(Dog)).Name);
        }

        [Fact]
        public void TestFindFirstCat()
        {
            AnimalShelter shelter = new AnimalShelter(new Dog("Moby"));
            shelter.Enqueue(new Cat("Boots"));
            Assert.Equal("Boots", shelter.FindFirst(typeof(Cat)).Name);
        }
        
        [Fact]
        public void TestFindFirstNotFound()
        {
            AnimalShelter shelter = new AnimalShelter(new Dog("Moby"));
            Assert.Throws<Exception>(() => shelter.FindFirst(typeof(Cat)));
        }

        [Fact]
        public void TestRemoveFront()
        {
            AnimalShelter shelter = new AnimalShelter(new Dog("Moby"));
            shelter.Enqueue(new Cat("Boots"));
            Assert.Equal("Moby", shelter.RemoveFront().Name);
        }

        [Fact]
        public void TestRemoveFrontWhenEmpty()
        {
            AnimalShelter shelter = new AnimalShelter(new Dog("Moby"));
            shelter.Dequeue("");
            Exception ex = Assert.Throws<Exception>(() => shelter.RemoveFront());
            Assert.Equal("The shelter is empty!", ex.Message);
        }

        [Fact]
        public void TestRemoveFrontNullNext()
        {
            AnimalShelter shelter = new AnimalShelter(new Dog("Moby"));
            shelter.Enqueue(new Cat("Boots"));
            Assert.Null(shelter.RemoveFront().Next);
        }
    }
}
