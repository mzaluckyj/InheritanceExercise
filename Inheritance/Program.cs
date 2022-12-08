using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common -done


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class -done

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class -done




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var Crow = new Bird();
                Crow.canFly = true;
                 Crow.featherColor = "Black";
                Crow.WillMigrate = true;
                 Crow.BeakLength = 3;



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var Lizard = new Reptile();
            Lizard.Habitat = "Desert";
            Lizard.isScaly = true;
            Lizard.TailRegen = true;
            Lizard.IsColdBlooded = true;


                var myAnimals = new Animal[] {Crow, Lizard};

            foreach( var animal in myAnimals)
            {
                Console.WriteLine($"Number of legs {animal.LegCount}");
                Console.WriteLine($"Has a tail? {animal.HasTail}");
                Console.WriteLine($"Age = {animal.Age}");
                Console.WriteLine($"Has feathers? {animal.HasFeathers}");
                Console.WriteLine();
            }
        }
    }
}
