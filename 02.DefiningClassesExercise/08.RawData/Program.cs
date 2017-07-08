using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var car = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var carModel = car[0];
                var engineSpeed = int.Parse(car[1]);
                var enginePower = int.Parse(car[2]);
                var cargoWeight = int.Parse(car[3]);
                var cargoType = car[4];
                var Tire1Pressure = double.Parse(car[5]);
                var Tire1Age = int.Parse(car[6]);
                var Tire2Pressure = double.Parse(car[7]);
                var Tire2Age = int.Parse(car[8]);
                var Tire3Pressure = double.Parse(car[9]);
                var Tire3Age = int.Parse(car[10]);
                var Tire4Pressure = double.Parse(car[11]);
                var Tire4Age = int.Parse(car[12]);

                var carEngine = new Engine(enginePower, engineSpeed);
                var carCargo = new Cargo(cargoWeight, cargoType);

                var tires = new Tire[4];
                tires[0] = new Tire(Tire1Pressure, Tire1Age);
                tires[1] = new Tire(Tire2Pressure, Tire2Age);
                tires[2] = new Tire(Tire3Pressure, Tire3Age);
                tires[3] = new Tire(Tire4Pressure, Tire4Age);



                cars.Add(new Car(carModel, carEngine, carCargo, tires));
            }
            var carsToPrint = new List<Car>();

            var command = Console.ReadLine();
            if (command.ToLower() == "flamable")
            {
                carsToPrint = cars.Where(x => x.engine.enginePower > 250).ToList();
            }
            else
            {
                foreach (Car car in cars)
                {
                    if (car.tires.Any(t => t.pressure < 1))
                    {
                        carsToPrint.Add(car);
                    }
                }
            }

            foreach (Car car in carsToPrint)
            {
                Console.WriteLine(car.model);
            }
        }
    }
}
