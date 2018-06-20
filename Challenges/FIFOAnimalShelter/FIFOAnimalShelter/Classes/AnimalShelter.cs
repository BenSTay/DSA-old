using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class AnimalShelter
    {
        protected Animal Front;
        protected Animal Rear;

        /// <summary>
        /// Creates a new instance of the AnimalShelter class.
        /// </summary>
        /// <param name="animal">The first animal in the AnimalShelter.</param>
        public AnimalShelter(Animal animal)
        {
            if (animal is Dog || animal is Cat)
            {
                Front = animal;
                Rear = animal;
            }
            else throw new Exception("Animal is not a Dog or a Cat!");
        }

        /// <summary>
        /// Adds a cat or a dog the the rear of the AnimalShelter.
        /// </summary>
        /// <param name="animal">The animal being added.</param>
        public void Enqueue(Animal animal)
        {
            if (animal is Cat || animal is Dog)
            {
                Rear.Next = animal;
                Rear = animal;
            }
            else
            {
                throw new Exception("Animal is not a Dog or a Cat!");
            }
        }

        /// <summary>
        /// Removes the front animal from the AnimalShelter.
        /// </summary>
        /// <returns>The front animal.</returns>
        public Animal RemoveFront()
        {
            if (Front != null)
            {
                Animal temp = Front;
                Front = Front.Next;
                temp.Next = null;
                return temp;
            }
            else throw new Exception("The shelter is empty!");
        }

        /// <summary>
        /// Removes the first animal in the AnimalShelter of a given type.
        /// </summary>
        /// <param name="type">The type of animal to be removed.</param>
        /// <returns>The first animal of a given type.</returns>
        public Animal FindFirst(Type type)
        {
            if (Front != null)
            {
                Animal runner = Front;
                while (runner.Next != null)
                {
                    if (runner.Next.GetType() == type)
                    {
                        Animal temp = runner.Next;
                        runner.Next = runner.Next.Next;
                        temp.Next = null;
                        return temp;
                    }
                    else runner = runner.Next;
                }
                throw new Exception("No Animal of that type is in the shleter!");
            }
            else throw new Exception("The shelter is empty!");
            
        }

        /// <summary>
        /// Removes an animal from the AnimalShelter.
        /// </summary>
        /// <param name="pref">The type of animal to be removed.</param>
        /// <returns>An animal.</returns>
        public Animal Dequeue(string pref)
        {
            switch (pref)
            {
                case "dog": if (Front is Dog) return RemoveFront();
                    else return FindFirst(typeof(Dog));
                case "cat": if (Front is Cat) return RemoveFront();
                    else return FindFirst(typeof(Cat));
                default: return RemoveFront();
            }
        }

        /// <summary>
        /// Returns a reference to the front animal in the AnimalShelter.
        /// </summary>
        /// <returns>The front animal.</returns>
        public Animal Peek()
        {
            return Front;
        }
    }
}
