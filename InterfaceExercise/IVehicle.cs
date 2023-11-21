using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public bool IsElectric { get; set; }
        public int NumberOfTires { get; set; }
        public double EngineSize { get; set; }
        public string Make { get; set; }

        public void Drive(); 
    }
}
