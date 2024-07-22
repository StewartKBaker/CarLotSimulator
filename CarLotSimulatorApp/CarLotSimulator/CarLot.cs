using System.Collections.Generic;
using System;

namespace CarLotSimulator;

public class CarLot
{
    public static int numberOfCars;
    
    public List<Car> Cars = new List<Car>();
    
    
    public void CarsInLot()
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine($"There are {numberOfCars} Cars in the Car Lot");
        var cars = 0;
        foreach(var car in Cars)
        {
            cars++;
            Console.WriteLine($"{cars}. {car.Year} {car.Make} {car.Model}");
        }
    }
}


