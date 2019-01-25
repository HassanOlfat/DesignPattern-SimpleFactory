using System;

namespace DesignPattern_SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = null;
            string carname = Console.ReadLine()?.ToLower();
            switch (carname)
            {
                case "volvo":
                    car = CarFactory.GetCar(Carsname.Volvo);
                    break;
                case "benz":
                    car = CarFactory.GetCar(Carsname.Benz);
                    break;
            }

            if (car != null) Console.WriteLine(car.GetCarPrice());
            Console.ReadKey();
        }
    }
}
