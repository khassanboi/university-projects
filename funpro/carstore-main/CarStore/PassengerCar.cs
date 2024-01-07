using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    class PassengerCar : Car
    {
        public PassengerCar()
        {
            IsIndustrial = false;
            IsPassenger = true;
        }
        public int MaxPas { get; set; }

        public override int GetMaxLoad()
        {
            return 0;
        }

        public override int GetMaxPas()
        {
            return MaxPas;
        }
    }
}
