using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    internal abstract class Vehicle
    {
        private double _driveTime;
        private double _drivePath;
        public double DriveTime
        {
            get
            {
                return _driveTime;
            }
            set
            {
                if (value>0)
                {
                    _driveTime = value;
                }
            }
        }
        public double DrivePath
        {
            get
            {
                return _drivePath;
            }
            set
            {
                if (value > 0)
                {
                    _drivePath = value;
                }
            }
        }
        public Vehicle(double driveTime, double drivePath)
        {
            DriveTime = driveTime;
            DrivePath = drivePath;
        }
        public abstract void AvarageSpeed();
    }
}
