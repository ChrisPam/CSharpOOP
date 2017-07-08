using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RawData
{
    public class Tire
    {
        public double pressure;
        public int age;

        public Tire(double pressure, int age)
        {
            this.pressure = pressure;
            this.age = age;
        }
    }
}
