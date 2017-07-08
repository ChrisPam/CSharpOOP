using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var engines = new Dictionary<string, Engine>();
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Engine engine;
                if (input.Length == 2)
                {
                    engine = new Engine(input[0], int.Parse(input[1]));
                }
                else if (input.Length == 3)
                {
                    int displacement;
                    bool isDisplacement = int.TryParse(input[2], out displacement);
                    if (isDisplacement)
                    {
                        engine = new Engine(input[0], int.Parse(input[1]), displacement);
                    }
                    else
                    {
                        engine = new Engine(input[0], int.Parse(input[1]), input[2]);
                    }
                }
                else
                {
                    engine = new Engine(input[0], int.Parse(input[1]), int.Parse(input[2]), input[3]);
                }

                engines.Add(input[0], engine);
            }

            var m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Car car;
                if (input.Length == 2)
                {
                    car = new Car(input[0], engines[input[1]]);
                }
                else if (input.Length == 3)
                {
                    int weight;
                    bool isWeight = int.TryParse(input[2], out weight);
                    if (isWeight)
                    {
                        car = new Car(input[0], engines[input[1]], weight);
                    }
                    else
                    {
                        car = new Car(input[0], engines[input[1]], input[2]);
                    }
                }
                else
                {
                    car = new Car(input[0], engines[input[1]], int.Parse(input[2]), input[3]);
                }

                cars.Add(car);
            }

            foreach (Car singleCar in cars)
            {
                Console.WriteLine($"{singleCar.model}:");
                Console.WriteLine($"  {singleCar.engine.model}:");
                Console.WriteLine($"    Power: {singleCar.engine.power}");
                Console.WriteLine($"    Displacement: {TryPrint(singleCar.engine.displacement)}");
                Console.WriteLine($"    Efficiency: {singleCar.engine.efficiency}");
                Console.WriteLine($"  Weight: {TryPrint(singleCar.weight)}");
                Console.WriteLine($"  Color: {singleCar.color}");
            }
        }

        private static string TryPrint(int parameter)
        {
            if (parameter == 0)
            {
                return "n/a";
            }
            else
            {
                return parameter.ToString();
            }
        }
    }
}
