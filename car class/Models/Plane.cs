using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_class.Models
{
    internal class Plane:Vehicle, IEngine
    {
        int _winglength;
        public int Winglength { get { return _winglength; }  set { if (value > 0) { _winglength = value; } } 
        }

        public int OilCapacity { get; set; }
        public int CurrentOil { get; set ; }
        public int FuelType { get; set; }
        void IEngine.RemainOilAmount()
        {
            Console.WriteLine(OilCapacity-CurrentOil);
        }
    }
}
