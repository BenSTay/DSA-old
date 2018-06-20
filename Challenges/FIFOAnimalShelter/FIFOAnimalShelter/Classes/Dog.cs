using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class Dog : Animal
    {
        /// <summary>
        /// Creates a new instance of the Dog class.
        /// </summary>
        /// <param name="name">The Dog's name.</param>
        public Dog(string name)
        {
            Name = name;
        }
    }
}
