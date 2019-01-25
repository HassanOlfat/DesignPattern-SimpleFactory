using System;

namespace DesignPattern_SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = null;
            string carname = Console.ReadLine().ToLower();
            if (carname == "volvo")
                car = CarFactory.GetCar(Carsname.Volvo);
            else if (carname == "benz")
                car = CarFactory.GetCar(Carsname.Benz);
            Console.WriteLine(car.GetCarPrice());
        }
    }
}
