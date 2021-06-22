using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Animal
    {
        // Create a class Animal
        // give this class 4 members that all Animals have in common
        public Animal()
        {

        }
        public int NumberOfLegs { get; set; }
        public string Type { get; set; }
        public int Age { get; set; }
        public bool IsGoodBoy { get; set; }
    }
}
