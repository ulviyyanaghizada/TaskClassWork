using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    internal class Bicycle : Vehicle, IEngine
    {
        private double _pedalKind;

        public double PedalKind
        {
            get
            {
                return _pedalKind;
            }
            set
            {
                if (value > 0)
                {
                    _pedalKind = value;
                }
            }
        }
        public Bicycle(double pedalkind, double drivePath, double driveTime):base(drivePath,driveTime)
        {
            PedalKind = pedalkind;
        }

        public double OilCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double CurrentOil { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double FuelType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AvarageSpeed()
        {
            Console.WriteLine(DrivePath/DriveTime);
        }

        public void RemainOilAmount()
        {
            Console.WriteLine();
        }
    }
}
