using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : IVehicle , ICompany 
    {
        public int BedLength { get; set; }
        public bool HasTailgate;
        public int NumberOfTires { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public void Drive()
        {
            Console.WriteLine($"Can tow the boat!");
        }

        public string Name { get; set; }
        public string Motto { get; set; }
    }
}
