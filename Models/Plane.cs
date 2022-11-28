using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    internal class Plane : Vehicle , IEngine

    {
        private double _wingLength;

        public double WingLength
        {
            get
            {
                return _wingLength;
            }
            set
            {
                if (value>0)
                {
                    _wingLength = value;
                }
            }
        }
        public Plane(double wingLenght, double drivePath, double driveTime) :base(drivePath, driveTime)
        {
            WingLength = wingLenght;
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
            Console.WriteLine();
        }
    }
}
