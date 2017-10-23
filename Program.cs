using System;
using System.Collections.Generic;

namespace testCsharp
{
    class Program
    {
        static List<string> cars = new List<string> { "Audi", "Mazda", "Ford", "Toyota" };
        static List<string> drivers = new List<string> { "BOB", "Lisa", "Tim", "Simon" };
        static void Main(string[] args)
        {
            Console.WriteLine(DisplayDriver());
            Console.WriteLine(DisplayDriver());
            Console.WriteLine(DisplayDriver());
            Console.WriteLine(DisplayDriver());
        }
        static int GenerateRandomNumber(List<string> myList)
        {
            var rand = new Random();
            return rand.Next(1, myList.Count);
        }
        static string DisplayDriver()
        {
            var selectedCars = cars[GenerateRandomNumber(cars)];
            var selectedDriver = drivers[GenerateRandomNumber(drivers)];
            return $"selected Driver = {selectedDriver}\nSelected Car = {selectedCars}";
        }

    }
}
