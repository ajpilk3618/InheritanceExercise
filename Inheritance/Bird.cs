using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird : Animal
    {
        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class
        public Bird()
        {

        }

        public string Name { get; set; }
        public double Wingspan { get; set; }
        public string BeakShape { get; set; }
        public bool CanFly { get; set; }
    }
}
