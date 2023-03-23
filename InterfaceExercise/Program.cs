using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Now, create objects of your 3 classes and give their members values;
            // I could also initialize these in the class itself
            var car = new Car 
            { 
                Logo = "Lion", 
                Name = "Leo", 
                NumberOfDoors = 4, 
                NumberOfPassengers = 4, 
                IsFourWheelDrive = true, 
                IsHatchback = true, 
                NumberOfWheels = 4, 
                Size = "tiny"
            };
            var truck = new Truck
            {
                Logo = "Little Man",
                Name = "Biff",
                IsFourWheelDrive = true,
                NumberOfDoors = 2,
                NumberOfPassengers = 2,
                NumberOfWheels = 6,
                IsWhip = true,
                Type = "overly large for no reason"
            };
            var suv = new SUV
            {
                Logo = "Soccer ball",
                Name = "Mommy",
                NumberOfDoors = 4,
                NumberOfPassengers = 5,
                NumberOfWheels = 4,
                IsFourWheelDrive = false,
                Color = "gray",
                Uses = "taking kids to soccer practice"
            };

            var vehicles = new List<IVehicle>() { car, truck, suv }; // creates a list of IVehicle and includes the car, truck, and suv   
            foreach ( var vehicle in vehicles )
            {
                vehicle.Drive();
                vehicle.Details();
            }
            //Creatively display and organize their values


            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

        }
    }
}
