using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RawData
{
    public class Car
    {
        public string model;
        public Engine engine;
        public Cargo cargo;
        public Tire[] tires;
        
        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            this.model = model;
            this.engine = engine;
            this.tires = tires;
        }
    }
}
