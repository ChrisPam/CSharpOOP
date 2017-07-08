using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var carModel = input[0];
            var fuelAmount = int.Parse(input[1]);
            var fuelConsumation = double.Parse(input[2]);

            cars.Add(new Car(carModel, fuelAmount, fuelConsumation));
        }

        var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        while (command[0].ToLower() != "end")
        {
            var carModel = command[1];
            var travelDistance = int.Parse(command[2]);

            var car = cars.Find(c => c.Model == carModel);
            try
            {
                car.Drive(travelDistance);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

        foreach (Car car in cars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTraveled}");
        }
    }
}