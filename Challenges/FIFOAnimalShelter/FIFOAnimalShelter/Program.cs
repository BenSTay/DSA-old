using FIFOAnimalShelter.Classes;
using System;

namespace FIFOAnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalShelter shelter = new AnimalShelter(new Dog("Moby"));
            shelter.Enqueue(new Cat("Boots"));
            shelter.Enqueue(new Dog("Coco"));
            Console.WriteLine(shelter.Dequeue("cat").Name);
            Console.WriteLine(shelter.Dequeue("dog").Name);
            Console.WriteLine(shelter.Dequeue("").Name);
            try
            {
                Console.WriteLine(shelter.Dequeue("dog"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
