using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class Cat : Animal
    {
        /// <summary>
        /// Creates a new instance of the Cat class.
        /// </summary>
        /// <param name="name">The Cat's name.</param>
        public Cat(string name)
        {
            Name = name;
        }
    }
}
