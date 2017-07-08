using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public IList<Product> GetProducts()
        {
            return this.bag.AsReadOnly();
        }

        public void BuyProduct(Product product)
        {
            if (this.money < product.Cost)
            {
                throw new InvalidOperationException($"{this.name} can't afford {product.Name}");
            }

            this.money -= product.Cost;
            this.bag.Add(product);
        }
    }
}
