using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : ICompany, IVehicle
    {
        // from ICompany
        public string Logo { get; set; }
        public string Name { get; set; }
        // from IVehicle
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public bool IsFourWheelDrive { get; set; }
        public int NumberOfPassengers { get; set; }
        // 2 unique things for this class
        public bool IsWhip { get; set; }
        public string Type { get; set; } // farm truck, looks, city truck, overcompensation

        public void Drive()
        {
            Console.WriteLine($"\nThe {Name} is driving. Do you like the {Logo} logo? It's {Type} and is sure to annoy everyone.\n");
        }

        public void Details()
        {
            Console.WriteLine("How about some details:");
            Console.WriteLine($"# of wheels: {NumberOfWheels}\n# of doors: {NumberOfDoors}\n# of passengers: {NumberOfPassengers}\n" +
                $"Four wheeled drive? {IsFourWheelDrive}\nDo your friends call your truck a whip? {IsWhip}\n");
        }
    }
}
