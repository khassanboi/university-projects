using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    public class ManageCars
    {
        private static ManageCars manageCarsClass;

        public static ManageCars GetCarManager()
        {
            if (manageCarsClass == null)
            {
                manageCarsClass = new ManageCars();
            }
            return manageCarsClass;
        }

        private List<Car> Cars = new List<Car>();

        public void PopulateStoreWithCars()
        {
            Cars.Add(new PassengerCar
            {
                Id = 001,
                Model = "X7",
                Brand = "BMW",
                MaxPas = 7
            });

            Cars.Add(new PassengerCar
            {
                Id = 001,
                Model = "X47",
                Brand = "BMW",
                MaxPas = 7
            });

            Cars.Add(new IndustrialCar
            {
                Id = 001,
                Model = "X7",
                Brand = "BMeW",
                MaxLoad = 700
            });

            Cars.Add(new IndustrialCar
            {
                Id = 001,
                Model = "X7",
                Brand = "BMeW",
                MaxLoad = 700
            });

            Cars.Add(new IndustrialCar
            {
                Id = 001,
                Model = "X7",
                Brand = "BMW",
                MaxLoad = 700
            });

            Cars.Add(new PassengerCar
            {
                Id = 001,
                Model = "X7",
                Brand = "BMW",
                MaxPas = 7
            });
        }

        public List<Car> GetAllCars()
        {
            return Cars;
        }

        public List<Car> GetCarsByModelOrBrandName(bool isPassenger, string value)
        {
            List<Car> FilteredCars = new List<Car>();

            foreach (Car car in Cars)
            {
                if (car.IsPassenger == isPassenger && (car.Model.ToLower().Trim() == value.ToLower().Trim() || car.Brand.ToLower().Trim() == value.ToLower().Trim()))
                {
                    FilteredCars.Add(car);
                }
            }

            return FilteredCars;
        }
    }
}
