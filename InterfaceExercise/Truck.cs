using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle , ICompany
    {
        public bool IsElectric { get; set; }
        public int NumberOfTires { get ; set; }
        public double EngineSize { get; set ; }
        public string Make { get; set; } // all from IVehicle above

        public bool CanOffRoad { get; set; } = true; 
        public bool HasBed { get; set; } // unique above 


        string ICompany.Logo { get ; set; }
        string ICompany.Motto { get ; set; } // from ICompany 

        public void Drive(string userInput)
        {
            throw new NotImplementedException();
        }

        public void Drive()
        {
            Console.WriteLine("I am driving a truck"); 
        }

       
    }
}
