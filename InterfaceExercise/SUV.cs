using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle , ICompany
    {
        public bool IsElectric { get; set; }
        public int NumberOfTires { get ; set; }
        public double EngineSize { get; set; }
        public string Make { get; set; }

        public bool AffordableGas { get; set; }
        public int NumberOfSeats { get; set; } // unique 
      
        
        string ICompany.Logo { get; set; }
        string ICompany.Motto { get ; set ; } // from ICompany

  

       public void Drive()
        {
            Console.WriteLine("I am driving a SUV");
        }
    }
}
