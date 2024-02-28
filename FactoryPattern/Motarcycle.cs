using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motarcycle : IVehicle
    {
        public string color { get; set; }

        public bool TowWheels { get; set; }

        public void Drive()
        {
            Console.WriteLine("Motorcycle are good");
        }
    }
}
