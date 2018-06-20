using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class Horse : Animal
    {
        /// <summary>
        /// Creates a new instance of the Horse class.
        /// </summary>
        /// <param name="name">The Horse's name.</param>
        public Horse(string name)
        {
            Name = name;
        }
    }
}
