using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04.ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new Dictionary<string, Person>();
            var products = new Dictionary<string, Product>();

            var personInput = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var productInput = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                foreach (var person in personInput)
                {
                    var input = person.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                    var personName = input[0];
                    var personMoney = decimal.Parse(input[1]);

                    var pers = new Person(personName, personMoney);
                    persons.Add(personName, pers);


                }

                foreach (var product in productInput)
                {
                    var input = product.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                    var productName = input[0];
                    var productCost = decimal.Parse(input[1]);

                    var prod = new Product(productName, productCost);
                    products.Add(productName, prod);
                }

                var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                while (command[0].ToLower() != "end")
                {
                    try
                    {
                        var buyer = persons[command[0]];
                        var productToBuy = products[command[1]];
                        buyer.BuyProduct(productToBuy);
                        Console.WriteLine($"{buyer.Name} bought {productToBuy.Name}");
                    }
                    catch (InvalidOperationException ioe)
                    {
                        Console.WriteLine(ioe.Message);
                    }

                    command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                }

                foreach (var person in persons)
                {
                    if (person.Value.GetProducts().Count > 0)
                        Console.WriteLine(
                            $"{person.Key} - {string.Join(", ", person.Value.GetProducts().Select(p => p.Name).ToList())}");
                    else
                        Console.WriteLine($"{person.Key} - Nothing bought");
                }
            }
            catch (ArgumentException aex)
            {
                Console.WriteLine(aex.Message);
            }
        }
    }
}
