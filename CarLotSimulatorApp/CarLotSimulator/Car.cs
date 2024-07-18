using System;

namespace CarLotSimulator;

public class Car
{
    public Car()
    {
    }

    public Car(int year, string make, string model, bool isDrivable, string engineNoise, string honkNoise)
    {
        Year = year;
        Make = make;
        Model = model;
        IsDrivable = isDrivable;
        EngineNoise = engineNoise;
        HonkNoise = honkNoise;
    }
    //Properties
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDrivable { get; set; }
    
    //Methods
    public void MakeEngineNoise() {Console.WriteLine(EngineNoise);}
    public void MakeHonkNoise() {Console.WriteLine(HonkNoise);}
}