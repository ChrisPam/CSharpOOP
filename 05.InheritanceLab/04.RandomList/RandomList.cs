using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class RandomList : ArrayList
{
    private Random rdn;

    public RandomList()
    {
        this.rdn = new Random();
    }
    
    public string RandomString()
    {
        return "";
    }
}