using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    internal class Car : Vehicle , IEngine
    {
        private double _doorCount; public double DoorCount
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
            }
        }
        public Car(double doorcount,double drivePath, double driveTime) : base(drivePath, driveTime)
        {
            DoorCount = doorcount;
        }

        public double OilCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double CurrentOil { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double FuelType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AvarageSpeed()
        {
            Console.WriteLine(DrivePath / DriveTime);
        }

        public void RemainOilAmount()
        {
            throw new NotImplementedException();
        }
    }
}
