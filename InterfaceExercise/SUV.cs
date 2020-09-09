using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle , ICompany
    {
        public int CargoSize { get; set;}
        public bool DvdPlayer;

        public int NumberOfTires { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public void Drive()
        {
            Console.WriteLine($"Has the gear and entertainment.");
        }

        public string Name { get; set; }
        public string Motto { get; set; }
    }

}
