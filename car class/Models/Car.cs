using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_class
{
    internal class Car:Vehicle, IEngine
    {
        private byte _doorCount;
        public byte DoorCount 
        {
            get
            {
                return _doorCount;  
            }
            set 
            {

                if (value > 0)
                {
                    _doorCount = value;
                }
                else
                {
                    Console.WriteLine("Wrong door count");
                }
            } 
        }
        public int OilCapacity { get; set ;}
        public int CurrentOil { get; set; }
        public int FuelType { get; set; }
        void IEngine.RemainOilAmount()
        {
            Console.WriteLine(OilCapacity-CurrentOil);
        }
    }
}
