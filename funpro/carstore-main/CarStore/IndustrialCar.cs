using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    class IndustrialCar : Car
    {
        public IndustrialCar()
        {
            IsIndustrial = true;
            IsPassenger = false;
        }
        public int MaxLoad { get; set; }

        public override int GetMaxLoad()
        {
            return MaxLoad;
        }

        public override int GetMaxPas()
        {
            return 0;
        }
    }
}
