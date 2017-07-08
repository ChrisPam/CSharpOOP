using System;

public class Car
{
    //Model, fuel amount, fuel consumption for 1 kilometer and distance traveled

    private string model;
    private double fuelAmount;
    private double fuelConsumption;
    private int distanceTraveled;

    public Car(string model, int fuelAmount, double fuelConsumption)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumption = fuelConsumption;
        this.DistanceTraveled = 0;
    }

    public Car(string model)
    {
        this.Model = model;
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public double FuelAmount
    {
        get { return this.fuelAmount; }
        set { this.fuelAmount = value; }
    }
    
    public double FuelConsumption
    {
        get { return this.fuelConsumption; }
        set { this.fuelConsumption = value; }
    }

    public int DistanceTraveled
    {
        get { return this.distanceTraveled; }
        set { this.distanceTraveled = 0; }
    }

    public void Drive(int distance)
    {
        var fluelCost = distance * this.fuelConsumption;

        if (fluelCost > this.fuelAmount)
        {
            throw new ArgumentException("Insufficient fuel for the drive");
        }
        this.fuelAmount -= fluelCost;
        this.distanceTraveled += distance;
    }
}
