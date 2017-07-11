using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Animal
{
    private string name;
    private string favouriteFood;

    public Animal(string name, string favouriteFood)
    {
        this.name = name;
        this.favouriteFood = favouriteFood;
    }
    public virtual string ExplainMyself()
    {
        return $"I am {this.name} and my fovourite food is {this.favouriteFood}";
    }
}
