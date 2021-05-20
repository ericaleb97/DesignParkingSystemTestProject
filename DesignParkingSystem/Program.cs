using System;
using System.Collections.Generic;

namespace DesignParkingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var parkingSystem = new ParkingSystem(2, 1, 3);
            Console.WriteLine(parkingSystem.AddCar(1));
            Console.WriteLine(parkingSystem.AddCar(2));
            Console.WriteLine(parkingSystem.AddCar(3));
            Console.WriteLine(parkingSystem.AddCar(1));
        }
    }
}
