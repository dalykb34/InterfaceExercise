using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : ICompany ,IVehicle
    {
        public bool hasTrunk = true;
        public int topSpeed { get; set; }

        public int NumberOfTires { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public void Drive()
        {
            Console.WriteLine($"Is the most affordable.");
        }

        public string Name { get; set; }
        public string Motto { get; set; }
    }
}
