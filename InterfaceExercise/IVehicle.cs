using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public bool IsFourWheelDrive { get; set; }
        public int NumberOfPassengers { get; set; }

        public void Drive();

        public void Details();
    }
}
