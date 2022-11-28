using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_class
{
    internal abstract class Vehicle
    {
        int _driveTime;
        int _drivePath;
        public int DriveTime
        {
            get { return _driveTime; }
            set
            {
                if (value > 0)
                {
                _driveTime = value; 
                }
                else
                {
                    Console.WriteLine("Wrong Input!!");
                }
            }
        }
        public int DrivePath
        {
            get { return _drivePath; }
            set
            {
                if (value > 0)
                {
                    _drivePath = value;
                }
                else
                {
                    Console.WriteLine("Wrong Input!!");
                }
            }
        }
        internal virtual void AverageSpeed()
        {
            Console.WriteLine(DrivePath / DriveTime);
        }

    }
}
