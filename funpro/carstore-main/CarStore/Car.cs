using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    public abstract class Car
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public bool IsPassenger { get; set; }
        public bool IsIndustrial { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public CarStatus Status { get; set; }

        public abstract int GetMaxPas();
        public abstract int GetMaxLoad();
    }

    public enum CarStatus
    {
        Available,
        Sold
    }
}
