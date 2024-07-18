using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var lot = new Carlot();
            
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Tacoma";
            myCar.Year = 2017;
            myCar.IsDrivable = true;
            myCar.EngineNoise = "vroom vroom";
            myCar.HonkNoise = "meep meep";
            
            myCar.MakeEngineNoise();
            myCar.MakeHonkNoise();
            
            lot.Cars.Add(myCar);

            var dadCar = new Car()
            {
                Make = "Ford",
                Model = "Tremor",
                Year = 2023,
                IsDrivable = true,
                EngineNoise = "VROOM",
                HonkNoise = "Beeeep"
            };
            
            dadCar.MakeEngineNoise();
            dadCar.MakeHonkNoise();
            
            lot.Cars.Add(dadCar);

            var momCar = new Car(2024, "Mercedes", "GLE", true, "voom", "beep");
            
            momCar.MakeEngineNoise();
            momCar.MakeHonkNoise();
            
            lot.Cars.Add(momCar);
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine($"There are {lot.Cars.Count} Cars in the Car Lot");
            var cars = 0;
            foreach(var car in lot.Cars)
            {
                cars++;
                Console.WriteLine($"{cars}. {car.Year} {car.Make} {car.Model}");
            }
        }
    }
}
