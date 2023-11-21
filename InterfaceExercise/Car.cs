using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle , ICompany 
    {
        public bool IsElectric { get; set; }
        public int NumberOfTires { get; set; }
        public double EngineSize { get; set; }
        public string Make { get; set; } // all from IVehicle above

        public int NumberOfDoors { get; set; }
        public int WheelSize { get; set; } // unique above 
        
        public string Logo { get ; set; }
        public string Motto { get; set; } // from ICompany above 

        public void Drive()
        {
            Console.WriteLine("I am driving a car ");
        }

       
    }
 }

