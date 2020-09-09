using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfTires { get; set; }
        public string Model { get; set; }
         public int Year { get; set; }
        public void Drive();
    }
}
