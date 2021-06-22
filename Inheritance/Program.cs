using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird bird = new Bird();
            bird.Name = "Blue Jay";
            bird.BeakShape = "pointy";
            bird.Wingspan = 15.3;
            bird.CanFly = true;


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Reptile reptile = new Reptile();
            reptile.Name = "Jerry";
            reptile.IsColdBlooded = true;
            reptile.IsVenomous = false;
            reptile.Habitat = "rivers";


        }
    }
}
