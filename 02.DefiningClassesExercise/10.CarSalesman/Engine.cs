using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CarSalesman
{
    public class Engine
    {
        public string model;
        public int power;
        public int displacement;
        public string efficiency;

        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.model = model;
            this.power = power;
            this.displacement = displacement;
            this.efficiency = efficiency;
        }

        public Engine(string model, int power)
            : this(model, power, 0, "n/a")
        {
        }

        public Engine(string model, int power, int displacement)
            : this(model, power, displacement, "n/a")
        {
        }

        public Engine(string model, int power, string efficiency)
            : this(model, power, 0, efficiency)
        {
        }
    }
}
