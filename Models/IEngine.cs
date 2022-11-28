using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    interface IEngine
    {
        public  double OilCapacity { get; set; }
        public double CurrentOil { get; set; }

        public double FuelType { get; set; }

        public void RemainOilAmount();

    }
}
