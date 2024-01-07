using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore
{
    class Program
    {
        private static bool searchForPassengerCar;
        private static string searchName;

        static void Main(string[] args)
        {
            ManageCars carManager = ManageCars.GetCarManager(); //singleton
            carManager.PopulateStoreWithCars();

            //start console writing
            Console.WriteLine("Here are cars");

            foreach (Car car in carManager.GetAllCars())
            {
                Console.Write("\n");
                Console.WriteLine("Model: " + car.Model);
                Console.WriteLine("Brand: " + car.Brand);
                Console.WriteLine("Type: " + (car.IsPassenger ? "Passenger" : "Industrial"));
                Console.Write("\n");
            }


            Console.WriteLine("Type 'i' for industrial or 'p' for passenger cars:");
            searchForPassengerCar = Console.ReadLine() == "p";

            Console.WriteLine("Type the name of model or brand to search:");
            searchName = Console.ReadLine();

            Console.WriteLine("Results:");

            foreach (Car car in carManager.GetCarsByModelOrBrandName(searchForPassengerCar, searchName))
            {
                Console.Write("\n");
                Console.WriteLine("Model: " + car.Model);
                Console.WriteLine("Brand: " + car.Brand);
                Console.WriteLine("Type: " + (car.IsPassenger ? "Passenger" : "Industrial"));
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
