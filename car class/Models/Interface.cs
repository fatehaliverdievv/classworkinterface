using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_class
{
    internal interface IEngine
    {
        public int OilCapacity { get; set; }
        public int CurrentOil { get; set; }
        public int FuelType { get; set; }
        internal abstract void RemainOilAmount();
    }
}
